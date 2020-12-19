
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  ** This notice applies to any and all portions of this file
  * that are not between comment pairs USER CODE BEGIN and
  * USER CODE END. Other portions of this file, whether 
  * inserted by the user or by software development tools
  * are owned by their respective copyright owners.
  *
  * COPYRIGHT(c) 2020 STMicroelectronics
  *
  * Redistribution and use in source and binary forms, with or without modification,
  * are permitted provided that the following conditions are met:
  *   1. Redistributions of source code must retain the above copyright notice,
  *      this list of conditions and the following disclaimer.
  *   2. Redistributions in binary form must reproduce the above copyright notice,
  *      this list of conditions and the following disclaimer in the documentation
  *      and/or other materials provided with the distribution.
  *   3. Neither the name of STMicroelectronics nor the names of its contributors
  *      may be used to endorse or promote products derived from this software
  *      without specific prior written permission.
  *
  * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
  * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
  * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
  * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
  * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
  * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
  * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
  * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
  * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
  * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
  *
  ******************************************************************************
  */
/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "stm32f1xx_hal.h"

/* USER CODE BEGIN Includes */
#include "ADE7753.h"
//#include "tm_stm32_hd44780.h"
#include "lcd_txt.h"
#include "rc522.h"
#include "stdio.h"
#include "stdlib.h"
#include <cstring>
#include <stdbool.h>
#include "math.h"
//#include <Sim80x.h>
#include <string.h>
#include "modbusRTU.h"
//include <stdio.h>
#define relay_on HAL_GPIO_WritePin(GPIOB,GPIO_PIN_1,GPIO_PIN_SET)
#define relay_off HAL_GPIO_WritePin(GPIOB,GPIO_PIN_1,GPIO_PIN_RESET)
//#define relay_off HAL_GPIO_WritePin(GPIOB,GPIO_PIN_1,GPIO_PIN_RESET)
/* USER CODE END Includes */

/* Private variables ---------------------------------------------------------*/
SPI_HandleTypeDef hspi1;
SPI_HandleTypeDef hspi2;

TIM_HandleTypeDef htim4;

UART_HandleTypeDef huart1;
UART_HandleTypeDef huart3;

/* USER CODE BEGIN PV */
/* Private variables ---------------------------------------------------------*/
char buffer[20];              // buffer LCD
float Vhd1 =0.0,Vhd2=0.0,Vhdtest=0.0;
float Ihd1 =0.0,Ihd2=0.0,Ihdtest=0.0;
uint32_t Vr_ADC=0;
uint32_t Ir_ADC=0;
char bfr_wifi1[200],bfr_wifi2[200],bfr_rs485[200];
uint8_t i=0,lcd_check=1;
uint8_t id=1;
uint16_t Voffset = 0, Ioffset = 0;
uint8_t R_gain;
uint8_t ver;
uint8_t R_CH1OS ;		 
uint8_t R_CH2OS ;
uint32_t Waveform ;
float freq1,freq2,freq;
float cosP1=0.0,cosP2=0.0,cosP=0.0;
float csP1=0.0,csP2=0.0,csP=0.0,P_peak=0.0,csP_nhan=0.0,csP_do=0.0;
float csS1=0.0,csS2=0.0,csS=0.0,S_peak=0.0,csS1_do;
float csQ1=0.0,csQ2=0.0,csQ=0.0, Q_peak=0.0;
float V_peak=0.0, I_peak=0.0 ;
uint16_t Flag1s = 0;

uint8_t count_Byte;
char current_Address;																	// Dia chi mod bus
char Rx_data;

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_SPI1_Init(void);
static void MX_SPI2_Init(void);
static void MX_USART1_UART_Init(void);
static void MX_USART3_UART_Init(void);
static void MX_TIM4_Init(void);

/* USER CODE BEGIN PFP */
/* Private function prototypes -----------------------------------------------*/

uint16_t modbus_crc(char *buf, int len)
{
    uint16_t crc = 0xFFFF;
 
    for (int pos = 0; pos < len; pos++) {
        crc ^= (uint16_t)buf[pos];          // XOR byte into least sig. byte of crc
 
        for (int i = 8; i != 0; i--) {    // Loop over each bit
            if ((crc & 0x0001) != 0) {      // If the LSB is set
                crc >>= 1;                    // Shift right and XOR 0xA001
                crc ^= 0xA001;
            } else                          // Else LSB is not set
                crc >>= 1;                    // Just shift right
        }
    }
    // Note, this number has low and high bytes swapped, so use it accordingly (or swap bytes)
    return crc;
}
/* END CRC Modbus Function */

/* BEGIN Read Holding Register Function */
void read_Holding_Reg(UART_HandleTypeDef* huart, char slave_address, char Holding_Reg[2], char quantity_Reg)
{
	current_Address = slave_address;
	count_Byte = 5 + (uint8_t)quantity_Reg*2;
	char L1V[8] = {slave_address, 0x03, Holding_Reg[0], Holding_Reg[1], 0x00, quantity_Reg, 0x22, 0x12};
	L1V[6] = modbus_crc(L1V,6) & 0xFF;
  L1V[7] = (modbus_crc(L1V,6)>>8) & 0xFF;
 
  TRANSFER_EN(); 
	
	HAL_Delay(1);
  HAL_UART_Transmit(huart, (uint8_t*)L1V, 8 ,1000);
  HAL_Delay(1);
	RECEIVER_EN();
	HAL_UART_Receive_IT(huart, (uint8_t*)&Rx_data, 1);
  
}
/* END Read Holding Register Function */

/* BEGIN TransferRTU Enable*/
void TRANSFER_EN(void)
{
	HAL_GPIO_WritePin(GPIOB, GPIO_PIN_9, GPIO_PIN_SET);
}
/* END TransferRTU Enable */

/* BEGIN TransferRTU Enable */
void RECEIVER_EN(void)
{
	HAL_GPIO_WritePin(GPIOB, GPIO_PIN_9, GPIO_PIN_RESET);
}
/* END TransferRTU Enable */


void clear1line(uint8_t line)
{
	for (uint8_t i =0 ; i <20 ; i++)
	{
		lcd_puts(line,i, (int8_t*)" ");
	}
}


void HAL_TIM_PeriodElapsedCallback(TIM_HandleTypeDef *htim4)
{
	if(htim4 -> Instance == TIM4)
	{
		Flag1s= Flag1s+1;
	}
}

void lcd_display(void)
{
	if((Flag1s>=0)&&(Flag1s<20)){
		if(lcd_check==1){
			clear1line(1);
			clear1line(2);
			clear1line(3);
			lcd_check=2;
			}
		
		sprintf(buffer,"Thong so to may id=%d",id);
		lcd_puts(0,0,(int8_t*)buffer);
		
		sprintf(buffer,"U1:%0.2f",Vhd1);
		lcd_puts(1,0,(int8_t*)buffer);
		
		sprintf(buffer,"U2:%0.2f",Vhd2);
		lcd_puts(1,10,(int8_t*)buffer);
		
		sprintf(buffer,"I1:%0.2f",Ihd1);
		lcd_puts(2,0,(int8_t*)buffer);

		sprintf(buffer,"I2:%0.2f",Ihd2);
		lcd_puts(2,10,(int8_t*)buffer);
		
		sprintf(buffer,"f1:%0.1f",freq1);
		lcd_puts(3,0,(int8_t*)buffer);
		
		sprintf(buffer,"f2:%0.1f",freq2);
		lcd_puts(3,10,(int8_t*)buffer);
	}

	if((Flag1s>=20)&&(Flag1s<40)) 
		{
			if(lcd_check==2){
				clear1line(1);
				clear1line(2);
				clear1line(3);
				lcd_check=3;
			}
		sprintf(buffer,"Thong so to may id=%d",id);
		lcd_puts(0,0,(int8_t*)buffer);
		sprintf(buffer,"P1:%0.2f",csP1);
		lcd_puts(1,0,(int8_t*)buffer);
		
		sprintf(buffer,"P2:%0.2f",csP2);
		lcd_puts(1,10,(int8_t*)buffer);
		
		sprintf(buffer,"Q1:%0.2f",csQ1);
		lcd_puts(2,0,(int8_t*)buffer);

		sprintf(buffer,"Q2:%0.2f",csQ2);
		lcd_puts(2,10,(int8_t*)buffer);
		
		sprintf(buffer,"cos1:%0.2f",cosP1);
		lcd_puts(3,0,(int8_t*)buffer);
		
		sprintf(buffer,"cos2:%0.2f",cosP2);
		lcd_puts(3,10,(int8_t*)buffer);
	
	}
			if((Flag1s>=40)&&(Flag1s<60)) 
		{
		if(lcd_check==3){
				clear1line(1);
				clear1line(2);
				clear1line(3);
				lcd_check=1;
			}
		sprintf(buffer,"Thong so to may id=%d",id);
		lcd_puts(0,0,(int8_t*)buffer);
		sprintf(buffer,"P:%0.2f",csP);
		lcd_puts(1,0,(int8_t*)buffer);
		
		sprintf(buffer,"Q:%0.2f",csQ);
		lcd_puts(1,10,(int8_t*)buffer);
		
		sprintf(buffer,"cosP:%0.2f",cosP);
		lcd_puts(2,0,(int8_t*)buffer);

		sprintf(buffer,"f:%0.2f",freq);
		lcd_puts(2,10,(int8_t*)buffer);
		
		sprintf(buffer,"P_p:%0.2f",P_peak);
		lcd_puts(3,0,(int8_t*)buffer);
		
		sprintf(buffer,"Q_p:%0.2f",Q_peak);
		lcd_puts(3,10,(int8_t*)buffer);
		if(Flag1s>=58){
			Flag1s = 0;
		
		}
		
	
	}

}

void sendata_RS485(){
			sprintf(bfr_rs485,"{\"Id\":\"%d\",\"U1\":\"%0.3f\",\"U2\":\"%0.3f\",\"I1\":\"%0.3f\",\"I2\":\"%0.3f\",\"cosP1\":\"%0.3f\",\"cosP2\":\"%0.3f\",\"csS\":\"%0.3f\",\"csP\":\"%0.3f\",\"csQ\":\"%0.3f\",\"cosP\":\"%0.3f\",\"freq\":\"%0.3f\",\"P_peak\":\"%0.3f\",\"Q_peak\":\"%0.3f\"}\n",id,Vhd1,Vhd2,Ihd1,Ihd2,cosP1,cosP2,csS,csP,csQ,cosP,freq,P_peak,Q_peak);
			HAL_UART_Transmit_IT(&huart3,(uint8_t*)bfr_rs485,strlen(bfr_rs485));
}
void sendata_wifi(){
			sprintf(bfr_wifi2,"{\"Id\":\"%d\",\"U1\":\"%0.3f\",\"U2\":\"%0.3f\",\"I1\":\"%0.3f\",\"I2\":\"%0.3f\",\"cosP1\":\"%0.3f\",\"cosP2\":\"%0.3f\"}\n",id,Vhd1,Vhd2,Ihd1,Ihd2,cosP1,cosP2);
			HAL_UART_Transmit_IT(&huart1,(uint8_t*)bfr_wifi2,strlen(bfr_wifi2));
			HAL_Delay(100);
			sprintf(bfr_wifi1,"{\"csS\":\"%0.3f\",\"csP\":\"%0.3f\",\"csQ\":\"%0.3f\",\"cosP\":\"%0.3f\",\"freq\":\"%0.3f\",\"P_peak\":\"%0.3f\",\"Q_peak\":\"%0.3f\"}\n",csS,csP,csQ,cosP,freq,P_peak,Q_peak);
			HAL_UART_Transmit_IT(&huart1,(uint8_t*)bfr_wifi1,strlen(bfr_wifi1));
			HAL_Delay(100);

}
void getdata(){
		Vhd1 = vrms1()/10*sqrt(3);	//Ty so bien ap la 10000:100 =100 doi ra KV thi chia 1000, ti le la 1/10 roi nhan can 3 de ra dien ap o so cap vi thu cap B noi dat
		Vhd2 = vrms2()/10*sqrt(3);
	
		Ihd1 = irms1()*1.6; // Ty so bien dong la 1600, doi ra KA ti so la 1600/1000 = 1.6
		Ihd2 = irms2()*1.6;
	
		csP1 = getP1()*0.16*sqrt(3); // ty le 1600*100/1e6 =0.16 MW, nhan can 3 de ra o so cap
		csP2 = getP2()*0.16*sqrt(3);
		csP = csP1 + csP2;
	
		csS1 = getS1()*0.16*sqrt(3);
		csS2 = getS2()*0.16*sqrt(3);
		csS = csS1+ csS2;
	
		csQ1 = csS1 - csP1;
		csQ2 = csS2- csP2;
		csQ  = csS - csP;
	
		cosP1 = csP1/csS1;
		cosP2 = csP2/csS2;
		cosP = csP/csS;
		
		freq1 = getFrecuency_1();
		freq2 = getFrecuency_2();
		freq = (freq1 +freq2)/2 ;		

}
void handle_pick(){
	if(csP>P_peak){
		P_peak = csP;
	}
	if(csQ> Q_peak){
		Q_peak = csQ;
	}
	
	
		
}
	

void Reset_ADE() {
	HAL_GPIO_WritePin(GPIOA,GPIO_PIN_1,GPIO_PIN_SET);
	//HAL_Delay(10);
	HAL_GPIO_WritePin(GPIOA,GPIO_PIN_1,GPIO_PIN_RESET);
	HAL_Delay(20);
	HAL_GPIO_WritePin(GPIOA,GPIO_PIN_1,GPIO_PIN_SET);
}
/* USER CODE END PFP */

/* USER CODE BEGIN 0 */
/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  *
  * @retval None
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration----------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_SPI1_Init();
  MX_SPI2_Init();
  MX_USART1_UART_Init();
  MX_USART3_UART_Init();
  MX_TIM4_Init();
  /* USER CODE BEGIN 2 */
	HAL_TIM_Base_Start_IT(&htim4);
	lcd_init();
	Reset_ADE();

//	lcd_puts(3,3,(int8_t*)"hello");
	
	
//	relay_on;
	
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
		getdata();
		handle_pick();
		sendata_RS485();
		sendata_wifi();
		HAL_GPIO_TogglePin(GPIOC,GPIO_PIN_13);
		HAL_Delay(100);
		lcd_display();

  /* USER CODE END WHILE */

  /* USER CODE BEGIN 3 */

  }
  /* USER CODE END 3 */

}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{

  RCC_OscInitTypeDef RCC_OscInitStruct;
  RCC_ClkInitTypeDef RCC_ClkInitStruct;

    /**Initializes the CPU, AHB and APB busses clocks 
    */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.HSEPredivValue = RCC_HSE_PREDIV_DIV1;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLMUL = RCC_PLL_MUL9;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

    /**Initializes the CPU, AHB and APB busses clocks 
    */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV2;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV2;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_2) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

    /**Configure the Systick interrupt time 
    */
  HAL_SYSTICK_Config(HAL_RCC_GetHCLKFreq()/1000);

    /**Configure the Systick 
    */
  HAL_SYSTICK_CLKSourceConfig(SYSTICK_CLKSOURCE_HCLK);

  /* SysTick_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(SysTick_IRQn, 0, 0);
}

/* SPI1 init function */
static void MX_SPI1_Init(void)
{

  /* SPI1 parameter configuration*/
  hspi1.Instance = SPI1;
  hspi1.Init.Mode = SPI_MODE_MASTER;
  hspi1.Init.Direction = SPI_DIRECTION_2LINES;
  hspi1.Init.DataSize = SPI_DATASIZE_8BIT;
  hspi1.Init.CLKPolarity = SPI_POLARITY_LOW;
  hspi1.Init.CLKPhase = SPI_PHASE_2EDGE;
  hspi1.Init.NSS = SPI_NSS_SOFT;
  hspi1.Init.BaudRatePrescaler = SPI_BAUDRATEPRESCALER_256;
  hspi1.Init.FirstBit = SPI_FIRSTBIT_MSB;
  hspi1.Init.TIMode = SPI_TIMODE_DISABLE;
  hspi1.Init.CRCCalculation = SPI_CRCCALCULATION_DISABLE;
  hspi1.Init.CRCPolynomial = 10;
  if (HAL_SPI_Init(&hspi1) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

}

/* SPI2 init function */
static void MX_SPI2_Init(void)
{

  /* SPI2 parameter configuration*/
  hspi2.Instance = SPI2;
  hspi2.Init.Mode = SPI_MODE_MASTER;
  hspi2.Init.Direction = SPI_DIRECTION_2LINES;
  hspi2.Init.DataSize = SPI_DATASIZE_8BIT;
  hspi2.Init.CLKPolarity = SPI_POLARITY_LOW;
  hspi2.Init.CLKPhase = SPI_PHASE_2EDGE;
  hspi2.Init.NSS = SPI_NSS_SOFT;
  hspi2.Init.BaudRatePrescaler = SPI_BAUDRATEPRESCALER_256;
  hspi2.Init.FirstBit = SPI_FIRSTBIT_MSB;
  hspi2.Init.TIMode = SPI_TIMODE_DISABLE;
  hspi2.Init.CRCCalculation = SPI_CRCCALCULATION_DISABLE;
  hspi2.Init.CRCPolynomial = 10;
  if (HAL_SPI_Init(&hspi2) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

}

/* TIM4 init function */
static void MX_TIM4_Init(void)
{

  TIM_ClockConfigTypeDef sClockSourceConfig;
  TIM_MasterConfigTypeDef sMasterConfig;

  htim4.Instance = TIM4;
  htim4.Init.Prescaler = 36000;
  htim4.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim4.Init.Period = 2000;
  htim4.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim4.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_ENABLE;
  if (HAL_TIM_Base_Init(&htim4) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

  sClockSourceConfig.ClockSource = TIM_CLOCKSOURCE_INTERNAL;
  if (HAL_TIM_ConfigClockSource(&htim4, &sClockSourceConfig) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim4, &sMasterConfig) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

}

/* USART1 init function */
static void MX_USART1_UART_Init(void)
{

  huart1.Instance = USART1;
  huart1.Init.BaudRate = 115200;
  huart1.Init.WordLength = UART_WORDLENGTH_8B;
  huart1.Init.StopBits = UART_STOPBITS_1;
  huart1.Init.Parity = UART_PARITY_NONE;
  huart1.Init.Mode = UART_MODE_TX_RX;
  huart1.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart1.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart1) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

}

/* USART3 init function */
static void MX_USART3_UART_Init(void)
{

  huart3.Instance = USART3;
  huart3.Init.BaudRate = 115200;
  huart3.Init.WordLength = UART_WORDLENGTH_8B;
  huart3.Init.StopBits = UART_STOPBITS_1;
  huart3.Init.Parity = UART_PARITY_NONE;
  huart3.Init.Mode = UART_MODE_TX_RX;
  huart3.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart3.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart3) != HAL_OK)
  {
    _Error_Handler(__FILE__, __LINE__);
  }

}

/** Configure pins as 
        * Analog 
        * Input 
        * Output
        * EVENT_OUT
        * EXTI
*/
static void MX_GPIO_Init(void)
{

  GPIO_InitTypeDef GPIO_InitStruct;

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOC_CLK_ENABLE();
  __HAL_RCC_GPIOD_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(led_GPIO_Port, led_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOA, GPIO_PIN_4|GPIO_PIN_15, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOB, GPIO_PIN_12|GPIO_PIN_3|GPIO_PIN_4|GPIO_PIN_5 
                          |GPIO_PIN_6|GPIO_PIN_7|GPIO_PIN_9, GPIO_PIN_RESET);

  /*Configure GPIO pin : led_Pin */
  GPIO_InitStruct.Pin = led_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(led_GPIO_Port, &GPIO_InitStruct);

  /*Configure GPIO pins : PC14 PC15 */
  GPIO_InitStruct.Pin = GPIO_PIN_14|GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  HAL_GPIO_Init(GPIOC, &GPIO_InitStruct);

  /*Configure GPIO pins : PA4 PA15 */
  GPIO_InitStruct.Pin = GPIO_PIN_4|GPIO_PIN_15;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : PB12 PB3 PB4 PB5 
                           PB6 PB7 PB9 */
  GPIO_InitStruct.Pin = GPIO_PIN_12|GPIO_PIN_3|GPIO_PIN_4|GPIO_PIN_5 
                          |GPIO_PIN_6|GPIO_PIN_7|GPIO_PIN_9;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

  /*Configure GPIO pin : PB8 */
  GPIO_InitStruct.Pin = GPIO_PIN_8;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @param  file: The file name as string.
  * @param  line: The line in file as a number.
  * @retval None
  */
void _Error_Handler(char *file, int line)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  while(1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t* file, uint32_t line)
{ 
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     tex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

/**
  * @}
  */

/**
  * @}
  */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
