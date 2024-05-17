using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GWInstekPS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GWInstekPS_Test
{
    public partial class Form1 : Form
    {
        GWInstekPS.GWInstekPS GWInstekObj;
        string COMPort = "COM1";
        int BaudRate = 9600;
        public Form1()
        {
            // Creating Object for the Driver Layer
            InitializeComponent();
            GWInstekObj = new GWInstekPS.GWInstekPS();
        }

        // Helping function to check the Text Box is Numeric or not
        static bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }

        // Connect the Powersupply with COM port  and baud rate
        private void Connect_Click(object sender, EventArgs e)
        {
            GWInstekObj.GetBaseLayerDLL(SourcePath.Text);
            GWInstekObj.Connect(COMPort,BaudRate);
            Signal.Text = "Connected";
        }

        // Button Click to Check the PS is Connected
        private void IsConnect_Click(object sender, EventArgs e)
        {
            bool isCon = GWInstekObj.IsConnected;
            MessageBox.Show("CONNECTED : "+isCon);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Method to Set the Current which is given in the TextBox
        private void SetCurrent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Current.Text) && IsNumeric(Current.Text))
            {
                MessageBox.Show("" + GWInstekObj.SetCurrent(double.Parse(Current.Text)));
            }
            else
            {
                Result.Text = "Value Should not be null or Alphabets";
            }
        }

        // Method to Set the Voltage which is given in the TextBox
        private void SetVoltage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Voltage.Text) && IsNumeric(Voltage.Text))
            {
                MessageBox.Show("" + GWInstekObj.SetVoltage(double.Parse(Voltage.Text)));
            }
            else
            {
                Result.Text = "Value Should not be null or Alphabets";

            }
        }

        // Button to make output Enable
        private void OutputEnable_Click(object sender, EventArgs e)
        {
            GWInstekObj.OutputEnable();
            OutputStatus.Text = "Enabled";
        }


        // Button to make output Disable
        private void OutputDisable_Click(object sender, EventArgs e)
        {
            GWInstekObj.OutputDisable();
            OutputStatus.Text = "Disabled";
        }

        // Method to set the Max Voltage protection to prevent OVER Voltage
        private void SetOVP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Voltage.Text) && IsNumeric(Voltage.Text))
            {
                GWInstekObj.SetOverVoltageProtection(double.Parse(Voltage.Text));
                Result.Text = "Voltage Protection : " + GWInstekObj.GetOverVoltageProtection();
            }
            else
            {
                Result.Text = "Value Should not be null or Alphabets";
            }
        }


        // Method to set the OVer Current Protection to prevent OVer Current
        private void SetOCP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Current.Text) && IsNumeric(Current.Text))
            {
                GWInstekObj.SetOverCurrentProtection(double.Parse(Current.Text));
                Result.Text = "Current Protection : " + GWInstekObj.GetOverCurrentProtection();
            }
            else
            {
                Result.Text = "Value Should not be null or Alphabets";
            }

        }


        // Method to Get the value which is set in the Over Voltage Protection
        private void GetOVP_Click(object sender, EventArgs e)
        {
            Result.Text = "Voltage Protection Value : " + GWInstekObj.GetOverVoltageProtection();
        }


        // Method to Get the value which is set in the Over Current Protection
        private void GetOCP_Click(object sender, EventArgs e)
        {
            Result.Text = "Current Protection  Value : " + GWInstekObj.GetOverCurrentProtection();
        }

        // Read the Current Value  that is Configured in PS
        private void ReadCurrent_Click(object sender, EventArgs e)
        {
            if (OutputStatus.Text.Equals("Enabled"))
                Result.Text = "Current Value : " + GWInstekObj.GetCurrentReading();
            else
                Result.Text = "Output to be enabled before Reading";
        }


        // Read the Voltage Value  that is Configured in PS
        private void ReadVoltage_Click(object sender, EventArgs e)
        {
            if (OutputStatus.Text.Equals("Enabled"))
                Result.Text = "Voltage Value : " + GWInstekObj.GetVoltageReading();
            else
                Result.Text = "Output to be enabled before Reading";
        }


        // Combo Box for COM port
        private void COMPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            COMPort = COMPortComboBox.SelectedItem.ToString();
        }

        // Combo Box for Baud Rate
        private void BaudRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaudRate = int.Parse(BaudRateComboBox.SelectedItem.ToString());
        }
    }
}
