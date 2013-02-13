//-----------------------------------------------------------------------------
//
//  mainForm.cs
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFF_GenericHID_Demo_Application
    {
    public partial class mainForm : Form
        {
        public mainForm()
            {
            InitializeComponent();

            // ATmega32U4 example firmware uses VID=0x03EB and PID=0x2150
            theUsbDemoDevice = new usbDemoDevice(0x03EB, 0x2150);

            // Add a listener for usb events
            theUsbDemoDevice.usbEvent += new usbDemoDevice.usbEventsHandler(usbEvent_receiver);

            // Perform an initial search for the target USB device (in case
            // it is already connected as we will not get an event for it)
            theUsbDemoDevice.findTargetDevice();
            }

        // Create an instance of the USB reference device object
        private usbDemoDevice theUsbDemoDevice;

        // Create a listener for USB events
        private void usbEvent_receiver(object o, EventArgs e)
            {
            // Check the status of the USB device and update the form accordingly
            if (theUsbDemoDevice.isDeviceAttached)
                {
                // USB Device is currently attached

                // Update the form's status label
                this.usbDeviceStatusLabel.Text = "USB Device is attached";

                // Update the form
                
                }
            else
                {
                // USB Device is currently unattached

                // Update the form's status label
                this.usbDeviceStatusLabel.Text = "USB Device is detached";

                // Update the form
                this.potStateLabel.Text = "0";
                this.potentiometerAnalogMeter.Value = 0;
                theUsbDemoDevice.PotState = 0;
                theUsbDemoDevice.Led1State = false;
                theUsbDemoDevice.Led2State = false;
                theUsbDemoDevice.Led3State = false;
                theUsbDemoDevice.Led4State = false;
                theUsbDemoDevice.Button1State = false;
                theUsbDemoDevice.Button2State = false;

                this.led1PictureBox.Image = Properties.Resources.red_off_16;
                this.led2PictureBox.Image = Properties.Resources.red_off_16;
                this.led3PictureBox.Image = Properties.Resources.red_off_16;
                this.led4PictureBox.Image = Properties.Resources.red_off_16;

                this.button1PictureBox.Image = Properties.Resources.blue_off_16;
                this.button2PictureBox.Image = Properties.Resources.blue_off_16;

                // Clear the debug window
                this.debugTextBox.Clear();
                }
            }

        // Every time the debug collection timer ticks we send a Generic HID
        // command to the device to collect debug text which is then placed
        // in the debug output textbox:
        private void debugCollectionTimer_Tick(object sender, EventArgs e)
            {
            String debugString;

            // Only collect debug if the device is attached
            if (theUsbDemoDevice.isDeviceAttached)
                {
                // Collect the debug information from the device
                debugString = theUsbDemoDevice.collectDebug();

                // Display the debug information
                if (debugString != String.Empty)
                    {
                    this.debugTextBox.AppendText(debugString);
                    }
                }
            }

        // LED1 clicked
        private void led1PictureBox_Click(object sender, EventArgs e)
            {
            if (theUsbDemoDevice.Led1State == false)
                {
                this.led1PictureBox.Image = Properties.Resources.red_on_16;
                theUsbDemoDevice.Led1State = true;
                }
            else
                {
                this.led1PictureBox.Image = Properties.Resources.red_off_16;
                theUsbDemoDevice.Led1State = false;
                }

            // Update the USB device
            theUsbDemoDevice.setDeviceStatus();
            }

        // LED2 clicked
        private void led2PictureBox_Click(object sender, EventArgs e)
            {
            if (theUsbDemoDevice.Led2State == false)
                {
                this.led2PictureBox.Image = Properties.Resources.red_on_16;
                theUsbDemoDevice.Led2State = true;
                }
            else
                {
                this.led2PictureBox.Image = Properties.Resources.red_off_16;
                theUsbDemoDevice.Led2State = false;
                }

            // Update the USB device
            theUsbDemoDevice.setDeviceStatus();
            }

        // LED3 clicked
        private void led3PictureBox_Click(object sender, EventArgs e)
            {
            if (theUsbDemoDevice.Led3State == false)
                {
                this.led3PictureBox.Image = Properties.Resources.red_on_16;
                theUsbDemoDevice.Led3State = true;
                }
            else
                {
                this.led3PictureBox.Image = Properties.Resources.red_off_16;
                theUsbDemoDevice.Led3State = false;
                }

            // Update the USB device
            theUsbDemoDevice.setDeviceStatus();
            }

        // LED4 clicked
        private void led4PictureBox_Click(object sender, EventArgs e)
            {
            if (theUsbDemoDevice.Led4State == false)
                {
                this.led4PictureBox.Image = Properties.Resources.red_on_16;
                theUsbDemoDevice.Led4State = true;
                }
            else
                {
                this.led4PictureBox.Image = Properties.Resources.red_off_16;
                theUsbDemoDevice.Led4State = false;
                }

            // Update the USB device
            theUsbDemoDevice.setDeviceStatus();
            }

        // When the device status poll timer ticks we query the USB device for status
        private void deviceStatusPollTimer_Tick(object sender, EventArgs e)
            {
            // Get the device's status
            theUsbDemoDevice.getDeviceStatus();

            // Update the form
            if (theUsbDemoDevice.Led1State == true) this.led1PictureBox.Image = Properties.Resources.red_on_16;
            else this.led1PictureBox.Image = Properties.Resources.red_off_16;
            if (theUsbDemoDevice.Led2State == true) this.led2PictureBox.Image = Properties.Resources.red_on_16;
            else this.led2PictureBox.Image = Properties.Resources.red_off_16;
            if (theUsbDemoDevice.Led3State == true) this.led3PictureBox.Image = Properties.Resources.red_on_16;
            else this.led3PictureBox.Image = Properties.Resources.red_off_16;
            if (theUsbDemoDevice.Led4State == true) this.led4PictureBox.Image = Properties.Resources.red_on_16;
            else this.led4PictureBox.Image = Properties.Resources.red_off_16;

            if (theUsbDemoDevice.Button1State == true) this.button1StateLabel.Text = "On";
            else this.button1StateLabel.Text = "Off";
            if (theUsbDemoDevice.Button2State == true) this.button2StateLabel.Text = "On";
            else this.button2StateLabel.Text = "Off";

            if (theUsbDemoDevice.Button1State == true) this.button1PictureBox.Image = Properties.Resources.blue_on_16;
            else this.button1PictureBox.Image = Properties.Resources.blue_off_16;
            if (theUsbDemoDevice.Button2State == true) this.button2PictureBox.Image = Properties.Resources.blue_on_16;
            else this.button2PictureBox.Image = Properties.Resources.blue_off_16;

            this.potStateLabel.Text = Convert.ToString(theUsbDemoDevice.PotState);
            this.potentiometerAnalogMeter.Value = theUsbDemoDevice.PotState;
            }
        }
    }
