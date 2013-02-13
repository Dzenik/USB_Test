//-----------------------------------------------------------------------------
//
//  usbReferenceDevices.cs
//
//  WFF GenericHID Test Application (Version 4_0)
//  A test application for the WFF GenericHID Communication Library
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

namespace WFF_GenericHID_Test_Application
    {
    using WFF_GenericHID_Communication_Library;

    /// <summary>
    /// This class performs several different tests against the 
    /// reference hardware/firmware to confirm that the USB
    /// communication library is functioning correctly.
    /// 
    /// It also serves as a demonstration of how to use the class
    /// library to perform different types of read and write
    /// operations.
    /// </summary>
    class usbReferenceDevice : WFF_GenericHID_Communication_Library
        {
        /// <summary>
        /// Class constructor - place any initialisation here
        /// </summary>
        /// <param name="vid"></param>
        /// <param name="pid"></param>
        public usbReferenceDevice(int vid, int pid) : base(vid, pid)
            {
            }

        public bool test1()
            {
            // Test 1 - Send a single write packet to the USB device

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[64];

            // Byte 0 must be set to our command
            outputBuffer[0] = 0x80;

            // Fill the rest of the buffer with known data
            int bufferPointer;
            Byte data = 0;
            for (bufferPointer = 1; bufferPointer < 64; bufferPointer++)
                {
                // We send the numbers 0 to 63 to the device
                outputBuffer[bufferPointer] = data;
                data++;
                }

            // Perform the write command
            bool success;
            success = writeSingleReportToDevice(outputBuffer);

            // We can't tell if the device receieved the data ok, we are
            // only indicating that the write was error free.
            return success;
            }

        public bool test2()
            {
            // Test 2 - Send a single write packet to the USB device and get
            // a single packet back
            Debug.WriteLine("Reference Application -> Starting Test 2");

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[64];

            // Declare our input buffer
            Byte[] inputBuffer = new Byte[64];

            // Byte 0 must be set to our command
            outputBuffer[0] = 0x81;

            // Fill the rest of the buffer with known data
            int bufferPointer;
            Byte data = 0;
            for (bufferPointer = 1; bufferPointer < 64; bufferPointer++)
                {
                // We send the numbers 0 to 63 to the device
                outputBuffer[bufferPointer] = data;
                data++;
                }

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

                // Test the received data; we expect 64 bytes:
                // bytes 0-63 should be filled with the numbers 0-63
                data = 0;
                for (bufferPointer = 0; bufferPointer < 64; bufferPointer++)
                    {
                    if (inputBuffer[bufferPointer] != data)
                        {
                        Debug.WriteLine("Reference Application -> TEST2: Incorrect data received from device!");
                        return false;
                        }
                    data++;
                    }
                success = true;
                }
            else Debug.WriteLine("Reference Application -> TEST2: Write report to device failed!"); 

            // The data was sent and received ok!
            return success;
            }

        public bool test3()
            {
            // Test 3 - Single packet write, 128 packets read
            Debug.WriteLine("Reference Application -> Starting Test 3");

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[64];

            // Declare our input buffer (this has to be 128 bytes * 64 bytes)
            Byte[] inputBuffer = new Byte[128*64];

            // Byte 0 must be set to our command
            outputBuffer[0] = 0x82;

            // Fill the rest of the buffer with known data
            int bufferPointer;
            Byte data = 0;
            for (bufferPointer = 1; bufferPointer < 64; bufferPointer++)
                {
                // We send the numbers 0 to 63 to the device
                outputBuffer[bufferPointer] = data;
                data++;
                }

            // Perform the write command
            bool success;
            success = writeSingleReportToDevice(outputBuffer);

            // Only proceed if the write was successful
            if (success)
                {
                Debug.WriteLine("Reference Application -> TEST3: Write command successful, packet sent");

                // Perform the read
                success = readMultipleReportsFromDevice(ref inputBuffer, 128);

                // Was the read successful?
                if (!success)
                    {
                    Debug.WriteLine("Reference Application -> TEST3: Read unsuccessful!}");
                    return false;
                    }

                // Test the received data
                for (int packetCounter = 0; packetCounter < 128; packetCounter++)
                    {
                    // Test the received data; we expect 65 bytes:
                    // bytes 0-63 should be filled with the number of the packet
                    for (bufferPointer = 0; bufferPointer < 63; bufferPointer++)
                        {
                        if (inputBuffer[bufferPointer + (packetCounter * 64)] != packetCounter)
                            {
                            Debug.WriteLine(string.Format(
                                "Reference Application -> TEST3: Invalid data - packet number {0}, byte number {1}",
                                packetCounter, bufferPointer));
                            Debug.WriteLine(string.Format(
                                "Reference Application -> TEST3: I expected {0}, but got {1}...",
                                packetCounter, inputBuffer[bufferPointer + (packetCounter * 65)]));
                            return false;
                            }
                        }
                    success = true;
                    }
                }

            // The data was sent and received ok!
            return success;
            }

        public bool test4()
            {
            // Test 4 - 128 packets write, single packet read
            Debug.WriteLine("Reference Application -> Starting Test 4");

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[128*64];

            // Declare our input buffer
            Byte[] inputBuffer = new Byte[64];

            // Byte 0 must be set to our command
            outputBuffer[0] = 0x83;

            // Fill the first part of the buffer with data (63 more bytes - 1 packet)
            Byte packet = 0;
            Byte byteNumber;
            int bufferPointer = 1;

            for (byteNumber = 1; byteNumber < 64; byteNumber++)
                {
                // We send the numbers 1 to 63 to the device
                outputBuffer[bufferPointer] = packet;
                bufferPointer++;
                }

            // Fill the rest of the buffer with the test pattern (127 more packets)
            for (packet = 1; packet < 128; packet++)
                {
                for (byteNumber = 0; byteNumber < 64; byteNumber++)
                    {
                    outputBuffer[bufferPointer] = packet;
                    bufferPointer++;
                    }
                }

            // Perform the write command
            bool success;
            success = writeMultipleReportsToDevice(outputBuffer, 128);

            if (!success)
                {
                Debug.WriteLine("Reference Application -> TEST4: Bulk send to device failed!");
                return false;
                }

            // If the write was successful get the returned packet from the device
            success = readSingleReportFromDevice(ref inputBuffer);

            // Was the read successful?
            if (!success)
                {
                Debug.WriteLine("Reference Application -> TEST4: Read reply from device unsuccessful!");
                return false;
                }

            // Test the received data; we expect 64 bytes:
            // bytes 0-63 should be filled with the numbers 0-63
            for (bufferPointer = 0; bufferPointer < 64; bufferPointer++)
                {
                if (inputBuffer[bufferPointer] != bufferPointer)
                    {
                    Debug.WriteLine("Reference Application -> TEST4: Incorrect data received from device!");
                    return false;
                    }
                }
            success = true;

            return true;
            }

        public bool test5()
            {
            // Test 5 - 128 packets write, 128 packets read
            Debug.WriteLine("Reference Application -> Starting Test 5");

            // Declare our output buffer
            Byte[] outputBuffer = new Byte[128 * 64];

            // Declare our input buffer
            Byte[] inputBuffer = new Byte[128 * 64];

            // Byte 0 must be set to our command
            outputBuffer[0] = 0x84;

            // Fill the first part of the buffer with data (63 more bytes - 1 packet)
            Byte packet = 0;
            Byte byteNumber;
            int bufferPointer = 1;

            for (byteNumber = 1; byteNumber < 64; byteNumber++)
                {
                // We send the numbers 1 to 63 to the device
                outputBuffer[bufferPointer] = packet;
                bufferPointer++;
                }

            // Fill the rest of the buffer with the test pattern (127 more packets)
            for (packet = 1; packet < 128; packet++)
                {
                for (byteNumber = 0; byteNumber < 64; byteNumber++)
                    {
                    outputBuffer[bufferPointer] = packet;
                    bufferPointer++;
                    }
                }

            // Perform the write command
            bool success;
            success = writeMultipleReportsToDevice(outputBuffer, 128);

            // Only proceed if the write was successful
            if (success)
                {
                Debug.WriteLine("Reference Application -> TEST5: Write command successful, 128 packets sent");

                // Perform the read
                success = readMultipleReportsFromDevice(ref inputBuffer, 128);

                // Was the read successful?
                if (!success)
                    {
                    Debug.WriteLine("Reference Application -> TEST5: Read unsuccessful!}");
                    return false;
                    }

                // Test the received data
                for (int packetCounter = 0; packetCounter < 128; packetCounter++)
                    {
                    // Test the received data; we expect 65 bytes:
                    // bytes 0-63 should be filled with the number of the packet
                    for (bufferPointer = 0; bufferPointer < 63; bufferPointer++)
                        {
                        if (inputBuffer[bufferPointer + (packetCounter * 64)] != packetCounter)
                            {
                            Debug.WriteLine(string.Format(
                                "Reference Application -> TEST5: Invalid data - packet number {0}, byte number {1}",
                                packetCounter, bufferPointer));
                            Debug.WriteLine(string.Format(
                                "Reference Application -> TEST5: I expected {0}, but got {1}...",
                                packetCounter, inputBuffer[bufferPointer + (packetCounter * 65)]));
                            return false;
                            }
                        }
                    success = true;
                    }
                }

            // The data was sent and received ok!
            return success;
            }

        // Collect debug information from the device
        public String collectDebug()
            {
            // Collect debug information from USB device
            Debug.WriteLine("Reference Application -> Collecting debug information from device");

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
                Debug.WriteLine("Reference Application -> Collecting debug - character counter was > 63!");
                return String.Empty;
                }

            // Convert the Byte array into a string of the correct length
            string s = System.Text.ASCIIEncoding.ASCII.GetString(inputBuffer, 1, inputBuffer[0]);

            return s;
            }
        }
    }
