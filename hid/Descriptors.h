//-----------------------------------------------------------------------------
//
//  Descriptors.h
//
//  WFF UDB GenericHID Demonstration Firmware (4_0)
//  A demonstration firmware for the WFF GenericHID Communication Library
//
//  Copyright (c) 2011 Simon Inns
//
//  Permission is hereby granted, free of charge, to any person obtaining a
//  copy of this software and associated documentation files (the "Software"),
//  to deal in the Software without restriction, including without limitation
//  the rights to use, copy, modify, merge, publish, distribute, sublicense,
//  and/or sell copies of the Software, and to permit persons to whom the
//  Software is furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//  FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//  DEALINGS IN THE SOFTWARE.
//
//  Web:    http://www.waitingforfriday.com
//  Email:  simon.inns@gmail.com
//
//-----------------------------------------------------------------------------

#ifndef _DESCRIPTORS_H_
#define _DESCRIPTORS_H_

// Includes
#include <avr/pgmspace.h>

#include "LUFA/Drivers/USB/USB.h"

// USB Descriptor Configuration Header (in LUFA library format)
typedef struct
{
	USB_Descriptor_Configuration_Header_t Config;

	// Generic HID Interface
	USB_Descriptor_Interface_t			HID_Interface;
	USB_HID_Descriptor_HID_t			HID_GenericHID;
	USB_Descriptor_Endpoint_t			HID_ReportINEndpoint;
} USB_Descriptor_Configuration_t;

// Macros
// Endpoint number of the Generic HID reporting IN endpoint
#define GENERIC_IN_EPNUM          1

// Endpoint number of the Generic HID reporting OUT endpoint. */
#define GENERIC_OUT_EPNUM         2

// Size in bytes of the Generic HID reporting endpoint
#define GENERIC_EPSIZE            8

// Size in bytes of the Generic HID reports (including report ID byte)
#define GENERIC_REPORT_SIZE       64

// Function Prototypes:
uint16_t CALLBACK_USB_GetDescriptor(const uint16_t wValue,
		                            const uint8_t wIndex,
		                            const void** const DescriptorAddress)
		                            ATTR_WARN_UNUSED_RESULT ATTR_NON_NULL_PTR_ARG(3);

#endif

