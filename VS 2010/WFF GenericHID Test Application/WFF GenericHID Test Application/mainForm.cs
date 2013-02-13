//-----------------------------------------------------------------------------
//
//  mainForm.cs
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFF_GenericHID_Test_Application
    {
    /// <summary>
    /// This is a reference application for testing the functionality of the 
    /// WFF GenericHID Communication Library.  It runs a series of 
    /// communication tests against a known USB reference device to determine
    /// if the class library is functioning correctly.
    /// 
    /// You can also use this application as a guide to integrating the 
    /// usbGenericHidCommunications class library into your projects.
    /// 
    /// See http://www,waitingforfriday.com for more detailed documentation.
    /// </summary>
    public partial class mainForm : Form
        {
        public mainForm()
            {
            InitializeComponent();

            // Create the USB reference device object (passing VID and PID)

            // PIC18F4550 example firmware uses VID=0x04D8 and PID=0x0080
            // ATmega32U4 example firmware uses VID=0x03EB and PID=0x214F
            theReferenceUsbDevice = new usbReferenceDevice(0x03EB, 0x214F);

            // Add a listener for usb events
            theReferenceUsbDevice.usbEvent += new usbReferenceDevice.usbEventsHandler(usbEvent_receiver);

            // Perform an initial search for the target USB device (in case
            // it is already connected as we will not get an event for it)
            theReferenceUsbDevice.findTargetDevice();
            }

        // Create an instance of the USB reference device object
        private usbReferenceDevice theReferenceUsbDevice;

        // Create a listener for USB events
        private void usbEvent_receiver(object o, EventArgs e)
            {
            // Check the status of the USB device and update the form accordingly
            if (theReferenceUsbDevice.isDeviceAttached)
                {
                // USB Device is currently attached

                // Update the form's status label
                this.usbDeviceStatusLabel.Text = "USB Device is attached";

                // Update the form
                this.test1Button.Enabled = true;
                this.test2Button.Enabled = true;
                this.test3Button.Enabled = true;
                this.test4Button.Enabled = true;
                this.test5Button.Enabled = true;
                }
            else
                {
                // USB Device is currently unattached

                // Update the form's status label
                this.usbDeviceStatusLabel.Text = "USB Device is detached";

                // Update the form
                this.test1Button.Enabled = false;
                this.test2Button.Enabled = false;
                this.test3Button.Enabled = false;
                this.test4Button.Enabled = false;
                this.test5Button.Enabled = false;

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
            if (theReferenceUsbDevice.isDeviceAttached)
                {
                // Collect the debug information from the device
                debugString = theReferenceUsbDevice.collectDebug();

                // Display the debug information
                if (debugString != String.Empty)
                    {
                    this.debugTextBox.AppendText(debugString);
                    }
                }
            }

        // The collect debug check box state has been changed
        private void collectDebugCheckBox_CheckedChanged(object sender, EventArgs e)
            {
            if (collectDebugCheckBox.Checked)
                {
                // Clear the debug window
                this.debugTextBox.Clear();

                // Enable the debug collection timer
                this.debugCollectionTimer.Enabled = true;
                }
            else this.debugCollectionTimer.Enabled = false;
            }

        // Test button 1 selected
        private void test1Button_Click(object sender, EventArgs e)
            {
            // Perform test 1
            if (theReferenceUsbDevice.test1()) this.test1ResultLabel.Text = "Test passed";
            else this.test1ResultLabel.Text = "Test failed";
            }

        // Test button 2 selected
        private void test2Button_Click(object sender, EventArgs e)
            {
            // Perform test 2
            if (theReferenceUsbDevice.test2()) this.test2ResultLabel.Text = "Test passed";
            else this.test2ResultLabel.Text = "Test failed";
            }

        // Test button 3 selected
        private void test3Button_Click(object sender, EventArgs e)
            {
            // Perform test 3
            if (theReferenceUsbDevice.test3()) this.test3ResultLabel.Text = "Test passed";
            else this.test3ResultLabel.Text = "Test failed";
            }

        // Test button 4 selected
        private void test4Button_Click(object sender, EventArgs e)
            {
            // Perform test 4
            if (theReferenceUsbDevice.test4()) this.test4ResultLabel.Text = "Test passed";
            else this.test4ResultLabel.Text = "Test failed";
            }

        // Test button 5 selected
        private void test5Button_Click(object sender, EventArgs e)
            {
            // Perform test 5
            if (theReferenceUsbDevice.test5()) this.test5ResultLabel.Text = "Test passed";
            else this.test5ResultLabel.Text = "Test failed";
            }

        private void wffWebLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            // Specify that the link was visited.
            this.wffWebLinkLabel.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://www.waitingforfriday.com");
            }
        }
    }
