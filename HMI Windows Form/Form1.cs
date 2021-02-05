using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;

namespace ReadSrial_Port_NEW_
{
    public partial class Forma1 : Form
    {
        bool toggleButton = true;
        String[] strPortName = SerialPort.GetPortNames();
        public Forma1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelConfirm.Text = "Click Scan and Select a Port";
            textBOX_Show_Read.ReadOnly = true;
            textBOX_Show_Read.Cursor = Cursors.Arrow;
            textBOX_Show_Read.GotFocus += textBOX_Show_Read_GotFocus;

        }
        private void textBOX_Show_Read_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }
        private void comboBox_selectedChange(object sender, EventArgs e)
        {

         

        }
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            if(toggleButton)
            {
                try
                {

                        serialPort1.BaudRate = 9600;
                        serialPort1.PortName = comboBox_Port.Text;
                        serialPort1.Open();
                    labelConfirm.ForeColor = System.Drawing.Color.Green;
                        labelConfirm.Text = "Connected to Port " + comboBox_Port.Text + " !";
                        BTN_Start.Text = "Disconnect";
                        toggleButton = !toggleButton;
                    }

                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                serialPort1.Close();
               BTN_Start.Text = "Connect";
                toggleButton = !toggleButton;
                labelConfirm.ForeColor = System.Drawing.Color.Red;
                labelConfirm.Text = "Disconnected from Port " + comboBox_Port.Text + " !";
                textHour.Clear();
                textMinute.Clear();
                textSecond.Clear();
                textBOX_Show_Read.Clear();
            }



        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {

                textBOX_Show_Read.Text = (serialPort1.ReadLine());
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }



        private void BTN_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    String format = textHour.Text+":"+ textMinute.Text+":" + textSecond.Text+'\n';
                    serialPort1.Write(format);
                    textHour.Clear();
                    textMinute.Clear();
                    textSecond.Clear();
                    labelConfirm.ForeColor = System.Drawing.Color.Green;
                    labelConfirm.Text = "Clock time changed successfully !";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelConfirm.ForeColor = System.Drawing.Color.Red;
                labelConfirm.Text = "Cannot send data !";
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            strPortName = SerialPort.GetPortNames();
            comboBox_Port.Items.Clear();
            foreach (string n in strPortName)
            {
                comboBox_Port.Items.Add(n);
            }
            comboBox_Port.SelectedIndex = 0;
            labelConfirm.Text = "Press Connect to read current time";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("hh:mm:ss");
            serialPort1.Write(time);
            textHour.Clear();
            textMinute.Clear();
            textSecond.Clear();
            labelConfirm.ForeColor = System.Drawing.Color.Green;
            labelConfirm.Text = "Synced with computer's local time !";
        }
    }
}
