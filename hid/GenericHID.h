#ifndef _GENERICHID_H_
#define _GENERICHID_H_

// Global includes
#include <avr/io.h>
#include <avr/wdt.h>
#include <avr/power.h>
#include <avr/interrupt.h>

// Local includes
#include "Descriptors.h"

// LUFA includes
#include "LUFA/Version.h"
#include "LUFA/Drivers/Board/LEDs.h"
#include "LUFA/Drivers/USB/USB.h"

// Function Prototypes:
void setupHardware(void);

void EVENT_USB_Device_Connect(void);
void EVENT_USB_Device_Disconnect(void);
void EVENT_USB_Device_ConfigurationChanged(void);
void EVENT_USB_Device_ControlRequest(void);
void EVENT_USB_Device_StartOfFrame(void);

#endif

