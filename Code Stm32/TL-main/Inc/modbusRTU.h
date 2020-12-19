/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : modbusRTU.h
  * @brief          : Header for modbusRTU.h file.
  *                   This file contains the common defines of the application.
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2019 Son-ManDevices.
  *
  ******************************************************************************
  */
/* USER CODE END Header */

/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __MODBUSRTU_H
#define __MODBUSRTU_H

#ifdef __cplusplus
extern "C" {
#endif

#include <stdint.h>
#include "main.h"
#include <stm32f1xx_hal.h>


#define Reg 							{0x01, 0xA2}

void read_Holding_Reg(UART_HandleTypeDef* huart, char slave_address, char Holding_Reg[2], char quantity_Reg);
uint16_t modbus_crc(char *buf, int len);
void RECEIVER_EN();
void TRANSFER_EN();

#ifdef __cplusplus
}
#endif

#endif /* __MAIN_H */

/************************ (C) COPYRIGHT Son-ManDevices *****END OF FILE****/
