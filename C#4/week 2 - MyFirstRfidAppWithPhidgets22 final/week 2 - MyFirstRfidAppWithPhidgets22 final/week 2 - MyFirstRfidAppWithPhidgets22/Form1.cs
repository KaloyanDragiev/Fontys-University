using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace week_2___MyFirstRfidAppWithPhidgets22
{
    public partial class Form1 : Form
    {
        private RFID myRFIDReader;
        public Form1()
        {
            InitializeComponent();
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowWhoIsAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowWhoIsDetached);
                myRFIDReader.Tag += new RFIDTagEventHandler(ProcessThisTag);

                listBox1.Items.Add("startup: so far so good.");
            }
            catch (PhidgetException) { listBox1.Items.Add("error at start-up."); }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.Open(); //if successfully, it will call the Attach-event.
            }
            catch (PhidgetException) { listBox1.Items.Add("no RFID-reader opened???????????"); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            myRFIDReader.Close();
            listBox1.Items.Add("closed ");
        }

        private void btnAntenna_Click(object sender, EventArgs e)
        {
            myRFIDReader.AntennaEnabled = !myRFIDReader.AntennaEnabled;
            if (myRFIDReader.AntennaEnabled) { this.btnAntenna.Text = "Switch antenna off"; }
            else { this.btnAntenna.Text = "Switch antenna on"; }
        }

        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            listBox1.Items.Add("RFIDReader attached!, device serial nr: " + myRFIDReader.DeviceSerialNumber);
        }

        private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
            listBox1.Items.Add("RFIDReader detached!, device serial nr: " + myRFIDReader.DeviceSerialNumber);
        }

        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
            listBox1.Items.Add("rfid has tag-nr: " + e.Tag);
        }

        private void btnAddSayHello_Click(object sender, EventArgs e)
        {
            this.myRFIDReader.Tag += new RFIDTagEventHandler(this.SayHello);
        }

        private void btnRemoveSayHello_Click(object sender, EventArgs e)
        {
            this.myRFIDReader.Tag -= new RFIDTagEventHandler(this.SayHello);
        }

        public void SayHello(object sender, RFIDTagEventArgs e)
        {
            MessageBox.Show("Hello visitor with rfid-nr " + e.Tag +
                ".\nWelcome at our event ! ! !");
        }
    }
}
