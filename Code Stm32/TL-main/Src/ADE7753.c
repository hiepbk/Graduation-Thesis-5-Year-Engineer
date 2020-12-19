#include "ADE7753.h"
#include <string.h>
#include "stm32f1xx_hal.h"
#include "math.h"

#define spi_enable HAL_GPIO_WritePin(GPIOA,GPIO_PIN_4,GPIO_PIN_RESET)
#define spi_disable HAL_GPIO_WritePin(GPIOA,GPIO_PIN_4,GPIO_PIN_SET)
#define spi_enable2 HAL_GPIO_WritePin(GPIOB,GPIO_PIN_12,GPIO_PIN_RESET)
#define spi_disable2 HAL_GPIO_WritePin(GPIOB,GPIO_PIN_12,GPIO_PIN_SET)
//=================
//variable
/* Private variables ---------------------------------------------------------*/
extern SPI_HandleTypeDef hspi1;
extern SPI_HandleTypeDef hspi2;
//  const uint8_t AFECS = 15;
//  const uint32_t spiFreq = 4000000;
  const uint8_t readingsNum = 10;
//  float vconst = ;
//  const float iconst = ;
//  const uint8_t interruptPin = 0;
//////////////////////////////

uint8_t read8_1(uint8_t reg)
{		
		spi_enable;
    uint8_t b0;
		HAL_Delay(5);
    HAL_SPI_Transmit(&hspi1, &reg,1,100);
    HAL_Delay(5);
    HAL_SPI_Receive(&hspi1, &b0,1,100);
		spi_disable;
		return b0;
}
uint8_t read8_2(uint8_t reg)
{		
		spi_enable2;
    uint8_t b0;
		HAL_Delay(5);
    HAL_SPI_Transmit(&hspi2, &reg,1,100);
    HAL_Delay(5);
    HAL_SPI_Receive(&hspi2, &b0,1,100);
		spi_disable2;
		return b0;
}

uint16_t read16_1(uint8_t reg)
{
		spi_enable;
    uint8_t b0,b1;
		HAL_Delay(5);
    HAL_SPI_Transmit(&hspi1, &reg,1,100);
    HAL_Delay(5);
    HAL_SPI_Receive(&hspi1, &b0,1,100);
		HAL_Delay(5);
    HAL_SPI_Receive(&hspi1, &b1,1,100);
		spi_disable;	
		return (uint16_t)b0<<8 | (uint16_t)b1;
}
uint16_t read16_2(uint8_t reg)
{
		spi_enable2;
    uint8_t b0,b1;
		HAL_Delay(5);
    HAL_SPI_Transmit(&hspi2, &reg,1,100);
    HAL_Delay(5);
    HAL_SPI_Receive(&hspi2, &b0,1,100);
		HAL_Delay(5);
    HAL_SPI_Receive(&hspi2, &b1,1,100);
		spi_disable2;	
		return (uint16_t)b0<<8 | (uint16_t)b1;
}

uint32_t read24_1(uint8_t reg)
{
		spi_enable;
    uint8_t b0,b1,b2;
		HAL_Delay(5);
    HAL_SPI_Transmit(&hspi1, &reg,1,100);
    HAL_Delay(5);
    HAL_SPI_Receive(&hspi1, &b0,1,100);
		HAL_Delay(5);
    HAL_SPI_Receive(&hspi1, &b1,1,100);
		HAL_Delay(5);
    HAL_SPI_Receive(&hspi1, &b2,1,100);
		HAL_Delay(5);
		spi_disable;	
		return (uint32_t)b0<<16 | (uint32_t)b1<<8 | (uint32_t)b2;
}

uint32_t read24_2(uint8_t reg)
{
		spi_enable2;
    uint8_t b0,b1,b2;
		HAL_Delay(5);
    HAL_SPI_Transmit(&hspi2, &reg,1,100);
    HAL_Delay(5);
    HAL_SPI_Receive(&hspi2, &b0,1,100);
		HAL_Delay(5);
    HAL_SPI_Receive(&hspi2, &b1,1,100);
		HAL_Delay(5);
    HAL_SPI_Receive(&hspi2, &b2,1,100);
		HAL_Delay(5);
		spi_disable2;	
		return (uint32_t)b0<<16 | (uint32_t)b1<<8 | (uint32_t)b2;
}

void write8_1(uint8_t reg, uint8_t data)
{
		spi_enable;
	  reg |= WRITE;
		HAL_Delay(10);
    HAL_SPI_Transmit(&hspi1, &reg,1,100);
    HAL_Delay(5);
    HAL_SPI_Transmit(&hspi1, &data,1,100);
		HAL_Delay(5);
		spi_disable;	
}
void write8_2(uint8_t reg, uint8_t data)
{
		spi_enable2;
	  reg |= WRITE;
		HAL_Delay(10);
    HAL_SPI_Transmit(&hspi2, &reg,1,100);
    HAL_Delay(5);
    HAL_SPI_Transmit(&hspi2, &data,1,100);
		HAL_Delay(5);
		spi_disable2;	
}

void write16_1(uint8_t reg, uint16_t data)
{
		spi_enable;
		uint8_t data0=0,data1=0;
	  reg |= WRITE;
		data0 = (uint8_t)data;
    data1 = (uint8_t)(data>>8);
		HAL_Delay(10);
    HAL_SPI_Transmit(&hspi1, &reg,1,100);
    HAL_Delay(5);
    HAL_SPI_Transmit(&hspi1, &data1,1,100); // sent msb first
		HAL_Delay(5);
		HAL_SPI_Transmit(&hspi1, &data0,1,100);
		HAL_Delay(5);
		spi_disable;	
}
void write16_2(uint8_t reg, uint16_t data)
{
		spi_enable2;
		uint8_t data0=0,data1=0;
	  reg |= WRITE;
		data0 = (uint8_t)data;
    data1 = (uint8_t)(data>>8);
		HAL_Delay(10);
    HAL_SPI_Transmit(&hspi2, &reg,1,100);
    HAL_Delay(5);
    HAL_SPI_Transmit(&hspi2, &data1,1,100); // sent msb first
		HAL_Delay(5);
		HAL_SPI_Transmit(&hspi2, &data0,1,100);
		HAL_Delay(5);
		spi_disable2;	
}

uint8_t getVersion(){
return read8_1(DIEREV);
}

/**=== setMode / getMode ===
MODE REGISTER (0x09)
The ADE7753 functionality is configured by writing to the mode register. Table 14 describes the functionality of each bit in the register.


Bit Location	Bit Mnemonic	Default Value 		Description
0				DISHPF			0					HPF (high-pass filter) in Channel 1 is disabled when this bit is set.
1				DISLPF2			0					LPF (low-pass filter) after the multiplier (LPF2) is disabled when this bit is set.
2				DISCF			1					Frequency output CF is disabled when this bit is set.
3				DISSAG			1					Line voltage sag detection is disabled when this bit is set.
4				ASUSPEND		0					By setting this bit to Logic 1, both ADE7753 A/D converters can be turned off.
													In normal operation, this bit should be left at Logic 0.
													All digital functionality can be stopped by suspending the clock signal at CLKIN pin.
5				TEMPSEL			0					Temperature conversion starts when this bit is set to 1.
													This bit is automatically reset to 0 when the temperature conversion is finished.
6				SWRST			0					Software Chip Reset. A data transfer should not take place to the
													ADE7753 for at least 18 µs after a software reset.
7				CYCMODE			0					Setting this bit to Logic 1 places the chip into line cycle energy accumulation mode.
8				DISCH1			0					ADC 1 (Channel 1) inputs are internally shorted together.
9				DISCH2			0					ADC 2 (Channel 2) inputs are internally shorted together.
10				SWAP			0					By setting this bit to Logic 1 the analog inputs V2P and V2N are connected to ADC 1
													and the analog inputs V1P and V1N are connected to ADC 2.
11 to 12		DTRT			0					These bits are used to select the waveform register update rate.
													DTRT1	DTRT0	Update Rate
													0		0		27.9 kSPS (CLKIN/128)
													0		1		14 kSPS (CLKIN/256)
													1		0		7 kSPS (CLKIN/512)
													1		1		3.5 kSPS (CLKIN/1024)
13 to 14		WAVSEL			0					These bits are used to select the source of the sampled data for the waveform register.
													WAVSEL[1:0]		Source
													0	0			24 bits active power signal (output of LPF2)
													0	1			Reserved
													1	0			24 bits Channel 1
													1	1			24 bits Channel 2
15				POAM			0					Writing Logic 1 to this bit allows only positive active power to be accumulated in the ADE7753.
*/
void setMode(uint16_t m){
    write16_1(MODE, m);
		write16_2(MODE, m);
}
uint16_t getMode_1(){
    return read16_1(MODE);
}
uint16_t getMode_2(){
    return read16_2(MODE);
}

/** === gainSetup ===

GAIN REGISTER (0x0F)
The PGA configuration of the ADE7753 is defined by writing to the GAIN register.
Table 18 summarizes the functionality of each bit in the GAIN register.

Bit Location		Bit Mnemonic		Default Value		Description
0 to 2				PGA1				0					Current GAIN
															PGA1[2:0]			Description
															0	0	0			x1
															0	0	1			x2
															0	1	0			x4
															0	1	1			x8
															1	0	0			x16
3 to 4				SCALE				0					Current input full-scale select
															SCALE[1:0]			Description
															0	0				0.5v
															0	1				0.25v
															1	0				0.125v
															1	1				Reserved
5 to 7				PGA2				0					Voltage GAIN
															PGA2[2:0]			Description
															0	0	0			x1
															0	0	1			x2
															0	1	0			x4
															0	1	1			x8
															1	0	0			x16
*/

void gainSetup(uint8_t integrator, uint8_t scale, uint8_t PGA2, uint8_t PGA1){
uint8_t pgas = (PGA2<<5) | (scale<<3) | (PGA1);
write8_1(GAIN,pgas);//write GAIN register, format is |3 bits PGA2 gain|2 bits full scale|3 bits PGA1 gain
write8_2(GAIN,pgas);
uint8_t ch1os = (integrator<<7);
write8_1(CH1OS,ch1os);
write8_2(CH1OS,ch1os);
}
/**	getStatus()/resetStatus()/getInterrupts()/setInterrupts(int i)
INTERRUPT STATUS REGISTER (0x0B), RESET INTERRUPT STATUS REGISTER (0x0C), INTERRUPT ENABLE REGISTER (0x0A)
The status register is used by the MCU to determine the source of an interrupt request (IRQ).
When an interrupt event occurs in the ADE7753, the corresponding flag in the interrupt status register is set to logic high.
If the enable bit for this flag is Logic 1 in the interrupt enable register, the IRQ logic output goes active low.
When the MCU services the interrupt, it must first carry out a read from the interrupt status register to determine the source of the interrupt.


Bit Location	Interrupt Flag		Description
0				AEHF				Indicates that an interrupt occurred because the active energy register, AENERGY, is more than half full.
1				SAG					Indicates that an interrupt was caused by a SAG on the line voltage.
2				CYCEND				Indicates the end of energy accumulation over an integer number of half line cycles as defined by
									the content of the LINECYC register—see the Line Cycle Energy Accumulation Mode section.
3				WSMP				Indicates that new data is present in the waveform register.
4				ZX					This status bit is set to Logic 0 on the rising and falling edge of the the voltage waveform.
									See the Zero-Crossing Detection section.
5				TEMP				Indicates that a temperature conversion result is available in the temperature register.
6				RESET				Indicates the end of a reset (for both software or hardware reset).
									The corresponding enable bit has no function in the interrupt enable register, i.e.,
									this status bit is set at the end of a reset, but it cannot be enabled to cause an interrupt.
7				AEOF				Indicates that the active energy register has overflowed.
8				PKV					Indicates that waveform sample from Channel 2 has exceeded the VPKLVL value.
9				PKI					Indicates that waveform sample from Channel 1 has exceeded the IPKLVL value.
A				VAEHF				Indicates that an interrupt occurred because the active energy register, VAENERGY, is more than half full.
B				VAEOF				Indicates that the apparent energy register has overflowed.
C				ZXTO				Indicates that an interrupt was caused by a missing zero crossing on the line voltage for the
									specified number of line cycles—see the Zero-Crossing Timeout section.
D				PPOS				Indicates that the power has gone from negative to positive.
E				PNEG				Indicates that the power has gone from positive to negative.
F				RESERVED			Reserved.

*/
uint16_t getInterrupts_1(void){
    return read16_1(IRQEN);
}
uint16_t getInterrupts_2(void){
    return read16_2(IRQEN);
}
void setInterrupts(uint16_t i){
    write16_1(IRQEN,i);
		write16_2(IRQEN,i);
}
uint16_t getStatus_1(void){
    return read16_1(STATUSR);
}

uint16_t getStatus_2(void){
    return read16_2(STATUSR);
}
uint16_t resetStatus_1(void){
    return read16_1(RSTSTATUS);
}
uint16_t resetStatus_2(void){
    return read16_1(RSTSTATUS);
}

/** === getIRMS ===
* Channel 2 RMS Value (Current Channel).
* The update rate of the Channel 2 rms measurement is CLKIN/4.
* To minimize noise, synchronize the reading of the rms register with the zero crossing
* of the voltage input and take the average of a number of readings.
* @param none
* @return long with the data (24 bits unsigned).
*/
uint32_t getIRMS_1(void){
//	uint32_t lastupdate = 0;
//	uint8_t t_of = 0;
	resetStatus_1(); // Clear all interrupts
	//lastupdate = millis();
	// tam thoi bo qua wait zero-crossing 
//	while(!(getStatus()&ZX)){   // wait Zero-Crossing
//	if ((millis() - lastupdate) > 20){
//		t_of = 1;
//		break;
//		}
//	}
//	if (t_of){
//	return 0;
//	}else{
	return read24_1(IRMS);
//	}
}
uint32_t getIRMS_2(void){
//	uint32_t lastupdate = 0;
//	uint8_t t_of = 0;
	resetStatus_2(); // Clear all interrupts
	//lastupdate = millis();
	// tam thoi bo qua wait zero-crossing 
//	while(!(getStatus()&ZX)){   // wait Zero-Crossing
//	if ((millis() - lastupdate) > 20){
//		t_of = 1;
//		break;
//		}
//	}
//	if (t_of){
//	return 0;
//	}else{
	return read24_2(IRMS);
//	}
}

uint32_t getWAVEFORM_1(void){
	resetStatus_1();
	return read24_1(WAVEFORM);
}
uint32_t getWAVEFORM_2(void){
	resetStatus_2();
	return read24_2(WAVEFORM);
}
/** === getVRMS ===
* Channel 2 RMS Value (Voltage Channel).
* The update rate of the Channel 2 rms measurement is CLKIN/4.
* To minimize noise, synchronize the reading of the rms register with the zero crossing
* of the voltage input and take the average of a number of readings.
* @param none
* @return long with the data (24 bits unsigned).
*/
uint32_t getVRMS_1(void){
//	uint32_t lastupdate = 0;
//	uint8_t t_of = 0;
	resetStatus_1(); // Clear all interrupts
//	lastupdate = millis();
//	while(!(getStatus()&ZX)){// wait Zero-Crossing
//	if((millis()-lastupdate) > 20                        ){
//		t_of = 1;
//		break;
//		}
//	}
//	if(t_of){
//		return 0;
//		}else{
		return read24_1(VRMS);
//		}
}

uint32_t getVRMS_2(void){
//	uint32_t lastupdate = 0;
//	uint8_t t_of = 0;
	resetStatus_2(); // Clear all interrupts
//	lastupdate = millis();
//	while(!(getStatus()&ZX)){// wait Zero-Crossing
//	if((millis()-lastupdate) > 20                        ){
//		t_of = 1;
//		break;
//		}
//	}
//	if(t_of){
//		return 0;
//		}else{
		return read24_2(VRMS);
//		}
}
/** === vrms ===
* Returns the mean of last 100 readings of RMS voltage. Also supress first reading to avoid
* corrupted data.
* rms measurement update rate is CLKIN/4.
* To minimize noise, synchronize the reading of the rms register with the zero crossing
* of the voltage input and take the average of a number of readings.
* @param none
* @return long with RMS voltage value
*/
float vrms1(){
	uint8_t c=0;
	uint32_t v=0;
	if(getVRMS_1()){//Ignore first reading to avoid garbage
	for(c=0;c<readingsNum;c++){
		v+=getVRMS_1();
	}
	return ((float)v/(float)readingsNum)*0.5*471.0/(1561400.0*sqrt(2.0));

	}else{
	return 0;
	}
}

float vrms2(){
	uint8_t c=0;
	uint32_t v=0;
	if(getVRMS_2()){//Ignore first reading to avoid garbage
	for(c=0;c<readingsNum;c++){
		v+=getVRMS_2();
	}
	return ((float)v/(float)readingsNum)*0.5*471.0/(1561400.0*sqrt(2.0));

	}else{
	return 0;
	}
}

/** === irms ===
* Returns the mean of last 100 readings of RMS current. Also supress first reading to avoid
* corrupted data.
* rms measurement update rate is CLKIN/4.
* To minimize noise, synchronize the reading of the rms register with the zero crossing
* of the voltage input and take the average of a number of readings.
* @param none
* @return long with RMS current value in hundreds of [mA], ie. 6709=67[mA]
*/
float irms1(){
	uint8_t n=0;
	uint32_t i=0;
	if(getIRMS_1()){//Ignore first reading to avoid garbage
	for(n=0;n<readingsNum;n++){
		i+=getIRMS_1();
	}
	return ((float)i/(float)readingsNum)*0.5*1000/(10.0*1868467*sqrt(2.0));
	}else{
	return 0;
	}
}
float irms2(){
	uint8_t n=0;
	uint32_t i=0;
	if(getIRMS_2()){//Ignore first reading to avoid garbage
	for(n=0;n<readingsNum;n++){
		i+=getIRMS_2();
	}
	return ((float)i/(float)readingsNum)*0.5*1000/(10.0*1868467*sqrt(2.0));
	}else{
	return 0;
	}
}
uint16_t getVRMSOS_1(void)
{
	return read16_1(VRMSOS);
};
uint16_t getVRMSOS_2(void)
{
	return read16_2(VRMSOS);
};
uint16_t getIRMSOS_1(void)
{
	return read16_1(IRMSOS);
};

uint16_t getIRMSOS_2(void)
{
	return read16_2(IRMSOS);
};
void setVRMSOS(uint16_t t)
{
	write16_1(VRMSOS,t);
	write16_2(VRMSOS,t);
};
void setIRMSOS(uint16_t t)
{
	write16_1(IRMSOS,t);
	write16_2(IRMSOS,t);
};

/**
 * Period of the Channel 2 (Voltage Channel) Input Estimated by Zero-Crossing Processing. The MSB of this register is always zero.
 * @param none
 * @return int with the data (16 bits unsigned).
 */
uint16_t getPeriod_1(void){
  uint32_t lastupdate = 0;
  uint8_t t_of = 0;
  resetStatus_1(); // Clear all interrupts
 // lastupdate = millis();
  while(!(getStatus_1()&ZX)){   // wait Zero-Crossing
 //if ((millis() - lastupdate) > 20){
		HAL_Delay(20);
		t_of = 1;
    break;
    }
 // }
  if (t_of){
  return 0;
  }
	else{
  return read16_1(PERIOD);
  }

}

uint16_t getPeriod_2(void){
  uint32_t lastupdate = 0;
  uint8_t t_of = 0;
  resetStatus_1(); // Clear all interrupts
 // lastupdate = millis();
  while(!(getStatus_2()&ZX)){   // wait Zero-Crossing
 //if ((millis() - lastupdate) > 20){
		HAL_Delay(20);
		t_of = 1;
    break;
    }
 // }
  if (t_of){
  return 0;
  }
	else{
  return read16_2(PERIOD);
  }

}


/**
 * Line Cycle Energy Accumulation Mode Line-Cycle Register.
 * This 16-bit register is used during line cycle energy accumulation  mode
 * to set the number of half line cycles for energy accumulation
 * @param none
 * @return int with the data (16 bits unsigned).
 */


/**
 * Zero-Crossing Timeout. If no zero crossings are detected
 * on Channel 2 within a time period specified by this 12-bit register,
 * the interrupt request line (IRQ) is activated
 * @param none
 * @return int with the data (12 bits unsigned).
 */
void setZeroCrossingTimeout(uint16_t d){
    write16_1(ZXTOUT,d);
		write16_2(ZXTOUT,d);
}
uint16_t getZeroCrossingTimeout_1(){
    return read16_1(ZXTOUT);
}
uint16_t getZeroCrossingTimeout_2(){
    return read16_2(ZXTOUT);
}
/**
 * Sag Line Cycle Register. This 8-bit register specifies the number of
 * consecutive line cycles the signal on Channel 2 must be below SAGLVL
 * before the SAG output is activated.
 * @param none
 * @return char with the data (8 bits unsigned).
 */
uint8_t getSagCycles_1(){
    return read8_1(SAGCYC);
}
uint8_t getSagCycles_2(){
    return read8_2(SAGCYC);
}
void setSagCycles(uint8_t d){
  write8_1(SAGCYC,d);  
	write8_2(SAGCYC,d);
}

/**
 * Sag Voltage Level. An 8-bit write to this register determines at what peak
 * signal level on Channel 2 the SAG pin becomes active. The signal must remain
 * low for the number of cycles specified in the SAGCYC register before the SAG pin is activated
 * @param none
 * @return char with the data (8 bits unsigned).
 */
uint8_t getSagVoltageLevel_1(){
    return read8_1(SAGLVL);
}
uint8_t getSagVoltageLevel_2(){
    return read8_2(SAGLVL);
}
void setSagVoltageLevel(uint8_t d){
    write8_1(SAGLVL,d);
		write8_2(SAGLVL,d);
}

/**
 * Channel 1 Peak Level Threshold (Current Channel). This register sets the levelof the current
 * peak detection. If the Channel 1 input exceeds this level, the PKI flag in the status register is set.
 * @param none
 * @return char with the data (8 bits unsigned).
 */
uint8_t getIPeakLevel(){
    return read8_1(IPKLVL);
}
void setIPeakLevel(uint8_t d){
    write8_1(IPKLVL,d);
}

/**
 * Channel 2 Peak Level Threshold (Voltage Channel). This register sets the level of the
 * voltage peak detection. If the Channel 2 input exceeds this level,
 * the PKV flag in the status register is set.
 * @param none
 * @return char with the data (8bits unsigned).
 */
uint8_t getVPeakLevel(){
    return read8_1(VPKLVL);
}
void setVPeakLevel(uint8_t d){
    write8_1(VPKLVL,d);
}

/**
 * Same as Channel 1 Peak Register except that the register contents are reset to 0 after read.
 * @param none
 * @return long with the data (24 bits 24 bits unsigned).
 */
uint32_t getIpeakReset(void){
    return read24_1(RSTIPEAK);
}

/**
 * Same as Channel 2 Peak Register except that the register contents are reset to 0 after a read.
 * @param none
 * @return long with the data (24 bits  unsigned).
 */
uint32_t getVpeakReset(void){
    return read24_1(RSTVPEAK);
}

/** === setPotLine(Phase) ===
Setea las condiciones para Line accumulation.
Luego espera la interrupccion y devuelve 1 cuando ocurre.
Si no ocurre por mas de 1,5 segundos devuelve un 0.
**/

void setLineCyc(uint16_t d){
    write16_1(LINECYC,d);
		write16_2(LINECYC,d);
}
uint8_t setPotLine(uint16_t Ciclos){
uint32_t lastupdate = 0;
uint8_t t_of = 0;
uint16_t m = 0;
m = m | DISCF | DISSAG | CYCMODE;
setMode(m);
resetStatus_1();
resetStatus_2();
setLineCyc(Ciclos);
//lastupdate = millis();
while(!(getStatus_1()&getStatus_2() & CYCEND))   // wait to terminar de acumular
	{ // wait for the selected interrupt to occur
//		if ((millis() - lastupdate) > (Ciclos*20))
		
		//HAL_Delay(Ciclos*20);
		
		t_of = 1;
		break;
		
	}

if(t_of){
	return 0;
}

//lastupdate = millis();
//while(!(getStatus() & CYCEND))   // wait to terminar de acumular
//	{ // wait for the selected interrupt to occur
//		if ((millis() - lastupdate) > (Ciclos*20))
//		{
//		t_of = 1;
//		break;
//		}
//	}
//	if(t_of){
//	return 0;
//	}
	else{
	return 1;
	}
}
/** === getWatt() / getVar() / getVa() ===
Devuelve los valores de la potencia requerida.
Utilizar antes setPotLine() para generar los valores.
**/
uint32_t getP1(){
  resetStatus_1(); // Clear all interrupts
	setPotLine(50);
  return read24_1(LAENERGY);
}
uint32_t getS1(){
  resetStatus_1(); // Clear all interrupts
	setPotLine(50);
	// tan so 50hz thi co 50 chu ki dong dien, lay A trong 50 chu ki chinh la cong suat
return read24_1(LVAENERGY);
}

uint32_t getQ1(){
	resetStatus_1(); // Clear all interrupts
	setPotLine(50);
return read24_1(LVARENERGY);
}

float getFrecuency_1(void){
	float freq;
	freq = 3579545/(4*32*(getPeriod_1()/16));
	return freq;
}


uint32_t getP2(){
  resetStatus_1(); // Clear all interrupts
	setPotLine(50);
  return read24_1(LAENERGY);
}
uint32_t getS2(){
  resetStatus_1(); // Clear all interrupts
	setPotLine(50);
	// tan so 50hz thi co 50 chu ki dong dien, lay A trong 50 chu ki chinh la cong suat
return read24_1(LVAENERGY);
}

uint32_t getQ2(){
	resetStatus_1(); // Clear all interrupts
	setPotLine(50);
return read24_1(LVARENERGY);
}

float getFrecuency_2(void){
	float freq;
	freq = 3579545/(4*32*(getPeriod_1()/16));
	return freq;
}



//void setIntPin(uint8_t interruptPin){
//  interruptPin = interruptPin;
//}
//void setInterruptFunction( void *(function)){
//  if (interruptPin){

//  }
//}