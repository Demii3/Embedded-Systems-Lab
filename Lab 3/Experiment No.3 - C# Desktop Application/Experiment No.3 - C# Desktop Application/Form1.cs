using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Experiment_No._3___C__Desktop_Application
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.Items.AddRange(ports);
            if (ports.Length == 0) 
            {
                cmbPorts.Items.Add("No ports available");
            }

            btnDisconnect.Enabled = false;
            cmbPorts.SelectedIndex = 0;
            cmbBaudrate.SelectedIndex = 1;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1 = new SerialPort(cmbPorts.Text, Convert.ToInt32(cmbBaudrate.Text));
                serialPort1.DataReceived += serialPort1_DataReceived;
                serialPort1.Open();

                lblConnectionStatus.Text = $"Now Connected to {serialPort1.PortName}";

                btnDisconnect.Enabled = true;
                lblConnectionStatus.Text = "Connected";
                btnConnect.Enabled = false;
                cmbPorts.Enabled = false;
                cmbBaudrate.Enabled = false;
            }
            catch (Exception exception)
            {
                lblConnectionStatus.Text = "Error: " + exception.Message;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = serialPort1.ReadLine(); // "light,motion"
                string[] parts = line.Trim().Split(',');
                this.BeginInvoke((MethodInvoker)delegate { // back to UI thread
                    try
                    {
                        lblLight.Text = parts[0];
                        lblMotion.Text = parts[1];
                        chart1.Series[0].Points.Add(double.Parse(parts[0]));
                    }
                    catch (Exception ex)
                    {
                        lblConnectionStatus.Text = "Disconnected due to:" + 
                                                    "\n\r" + 
                                                    ex.Message + 
                                                    "\n\r" + "Connect to the Port again.";
                        serialPort1.DataReceived -= serialPort1_DataReceived;
                        if (serialPort1.IsOpen)
                        {
                            serialPort1.Close();
                        }
                      
                        btnDisconnect.Enabled = false;
                        btnConnect.Enabled = true;
                        cmbPorts.Enabled = true;
                        cmbBaudrate.Enabled = true;
                    }
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ello", MessageBoxButtons.OK);
            }
        }

        private void btnClearChart_Click(object sender, EventArgs e)
        {
            if (chart1.Series.Count > 0)
            {
                chart1.Series[0].Points.Clear();
                lblLight.Text = "0";
                lblMotion.Text = "0";
            }
        }

        private async void btnDisconnect_Click_1(object sender, EventArgs e)
        {
            btnDisconnect.Enabled = false;

            if (serialPort1 != null && serialPort1.IsOpen)
            {
                try
                {
                    // Close the port on a background thread to avoid blocking the UI
                    serialPort1.Close();
                    lblConnectionStatus.Text = "Disconnected";
                }
                catch (Exception ex)
                {
                    lblConnectionStatus.Text = $"Error closing port: \n{ex.Message}";
                }
            }

            btnConnect.Enabled = true;
            cmbPorts.Enabled = true;
            cmbBaudrate.Enabled = true;
            lblConnectionStatus.Text = "Disconnected";
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            if (serialPort1 != null && serialPort1.IsOpen)
            {
                lblConnectionStatus.Text = $"Connected to {serialPort1.PortName}";
            }
            else
            {
                lblConnectionStatus.Text = "Not connected";
                btnConnect.Enabled = true;
                cmbPorts.Enabled = true;
                cmbBaudrate.Enabled = true;

                cmbPorts.Items.Clear();
                string[] ports = SerialPort.GetPortNames();
                cmbPorts.Items.AddRange(ports);
                if (ports.Length == 0)
                {
                    cmbPorts.Items.Add("No ports available");
                }

                btnDisconnect.Enabled = false;
                cmbPorts.SelectedIndex = 0;
            }
        }
    }
}
