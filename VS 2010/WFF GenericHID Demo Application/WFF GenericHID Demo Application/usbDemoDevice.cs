//-----------------------------------------------------------------------------
//
//  usbDemoDevice.cs
//
//  WFF UDB GenericHID Demonstration Application (Version 4_0)
//  A demonstration application for the WFF GenericHID Communication Library
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// The following namespace allows debugging output (when compiled in debug mode)
using System.Diagnostics;

namespace WFF_GenericHID_Demo_Application
    {
    using WFF_GenericHID_Communication_Library;

    class usbDemoDevice : WFF_GenericHID_Communication_Library
        {
        /// <summary>
        /// Class constructor - place any initialisation here
        /// </summary>
        /// <param name="vid"></param>
        /// <param name="pid"></param>
        public usbDemoDevice(int vid, int pid) : base(vid, pid)
            {
            // Initialise the local copy of the device's state
            deviceState.led1State = false;
            deviceState.led2State = false;
            deviceState.led3State = false;
            deviceState.led4State = false;
            deviceState.button1State = false;
            deviceState.button2State = false;
            deviceState.potState = 0;
            }

        // Methods to store and access a local copy of the device's state

        // Initialise the local copy of the device's state
        private struct deviceStateStruct
            {
            public Boolean led1State;
            public Boolean led2State;
            public Boolean led3State;
            public Boolean led4State;
            public Boolean button1State;
            public Boolean button2State;
            public Int64 potState;
            }

        // Create a game state object
        private deviceStateStruct deviceState;

        // Accessor classes for the device's state values
        public Boolean Led1State
            {
            get { return deviceState.led1State; }
            set { deviceState.led1State = value; }
            }
        public Boolean Led2State
            {
            get { return deviceState.led2State; }
            set { deviceState.led2State = value; }
            }
        public Boolean Led3State
            {
            get { return deviceState.led3State; }
            set { deviceState.led3State = value; }
            }
        public Boolean Led4State
            {
            get { return deviceState.led4State; }
            set { deviceState.led4State = value; }
            }
        public Boolean Button1State
            {
            get { return deviceState.button1State; }
            set { deviceState.button1State = value; }
            }
        public Boolean Button2State
            {
            get { return deviceState.button2State; }
            set { deviceState.button2State = value; }
            }
        public Int64 PotState
            {
            get { return deviceState.potState; }
            set { deviceState.potState = value; }
            }

        // Code to send commands to the device ----------

        public bool getDeviceStatus()
            {
            // Command 0x80 - Get device status
            Debug.WriteLine("Demo Application -> Sending get device status command (0x80) to USB device");

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[64];

            // Declare our input buffer
            Byte[] inputBuffer = new Byte[64];

            // Byte 0 must be set to our command
            outputBuffer[0] = 0x80;

            // Perform the write command
            bool success;
            success = writeSingleReportToDevice(outputBuffer);

            // Only proceed if the write was successful
            if (success)
                {
                // Perform the read
                success = readSingleReportFromDevice(ref inputBuffer);

                // Was the read successful?
                if (!success) return false;

                // Grab the status information and process
                
                // LEDs
                if (inputBuffer[0] == 1) deviceState.led1State = true; else deviceState.led1State = false;
                if (inputBuffer[1] == 1) deviceState.led2State = true; else deviceState.led2State = false;
                if (inputBuffer[2] == 1) deviceState.led3State = true; else deviceState.led3State = false;
                if (inputBuffer[3] == 1) deviceState.led4State = true; else deviceState.led4State = false;

                // Buttons
                if (inputBuffer[4] == 1) deviceState.button1State = true; else deviceState.button1State = false;
                if (inputBuffer[5] == 1) deviceState.button2State = true; else deviceState.button2State = false;

                // Potentiometer (covert 2 bytes to 16 bit integer)
                deviceState.potState = (inputBuffer[6] << 8) + inputBuffer[7];

                success = true;
                }
            else Debug.WriteLine("Reference Application -> TEST2: Write report to device failed!"); 

            // The data was sent and received ok!
            return success;
            }

        public bool setDeviceStatus()
            {
            // Command 0x81 - Set device status
            Debug.WriteLine(
                "Demo Application -> Sending set device status command (0x81) to USB device");

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[64];

            // Byte 0 must be set to our command
            outputBuffer[0] = 0x81;

            // Set the packet data according to the local LED status
            if (deviceState.led1State == true) outputBuffer[1] = 1; else outputBuffer[1] = 0;
            if (deviceState.led2State == true) outputBuffer[2] = 1; else outputBuffer[2] = 0;
            if (deviceState.led3State == true) outputBuffer[3] = 1; else outputBuffer[3] = 0;
            if (deviceState.led4State == true) outputBuffer[4] = 1; else outputBuffer[4] = 0;

            // Perform the write command
            bool success;
            success = writeSingleReportToDevice(outputBuffer);

            return success;
            }

        // Collect debug information from the device
        public String collectDebug()
            {
            // Collect debug information from USB device
            Debug.WriteLine("Demo Application -> Collecting debug information from device");

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[64];

            // Declare our input buffer
            Byte[] inputBuffer = new Byte[64];

            // Byte 0 must be set to our command
            outputBuffer[0] = 0x10;

            // Send the collect debug command
            writeSingleReportToDevice(outputBuffer);

            // Read the response from the device
            readSingleReportFromDevice(ref inputBuffer);

            // Byte 0 contains the number of characters transfered
            if (inputBuffer[0] == 0) return String.Empty;

            // Sanity check the number of characters
            if (inputBuffer[0] > 63)
                {
                Debug.WriteLine("Demo Application -> Collecting debug - character counter was > 63!");
                return String.Empty;
                }

            // Convert the Byte array into a string of the correct length
            string s = System.Text.ASCIIEncoding.ASCII.GetString(inputBuffer, 1, inputBuffer[0]);

            return s;
            }
        }
    }
