/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : zigbee_coor.c
  * @brief          : module program body
	* Author					: Le Hong Son
	* Project					: Coordinator module DATN
  ******************************************************************************
  * @attention

  ******************************************************************************
  */
/* USER CODE END Header */
#include "modbusRTU.h"

extern uint8_t count_Byte;
extern char current_Address;																	// Dia chi mod bus
extern char Rx_data;

/* BEGIN CRC Modbus Function */
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
	HAL_GPIO_WritePin(GPIOA, GPIO_PIN_8, GPIO_PIN_SET);
}
/* END TransferRTU Enable */

/* BEGIN TransferRTU Enable */
void RECEIVER_EN(void)
{
	HAL_GPIO_WritePin(GPIOA, GPIO_PIN_8, GPIO_PIN_RESET);
}
/* END TransferRTU Enable */
