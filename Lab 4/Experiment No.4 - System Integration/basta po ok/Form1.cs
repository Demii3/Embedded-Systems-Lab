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

namespace basta_po_ok
{
    public partial class Form1 : Form
    {
        DateTime tStart;
        SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();

            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataReceived += OnDataReceived;

            string[] ports = SerialPort.GetPortNames();

            cmbPorts.Items.AddRange(ports);

            if (cmbPorts.Items.Count > 0)
            {
                cmbPorts.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnConnectPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPorts.SelectedItem == null)
                {
                    MessageBox.Show("Please select a COM port.");
                    return;
                }

                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = cmbPorts.SelectedItem.ToString();
                    serialPort.Open();

                    lblPorts.Text = "Port Connected";
                    lblPorts.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lblPorts.Text = "Connection Error";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnectPort_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();

                lblPorts.Text = "Port Disconnected";
                lblPorts.ForeColor = Color.Red;
            }
        }

        private void btnLedOn_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Not Connected");
                return;
            }

            tStart = DateTime.Now;
            serialPort.Write("1");

            lblLed.Text = "LED is ON";
            lblLed.ForeColor = Color.Green;
        }

        private void btnLedOff_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Not Connected");
                return;
            }

            tStart = DateTime.Now;
            serialPort.Write("0");

            lblLed.Text = "LED is OFF";
            lblLed.ForeColor = Color.Red;
        }

        private void OnDataReceived(object s, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = serialPort.ReadLine().Trim();
                string[] parts = line.Split(',');

                this.Invoke((MethodInvoker)delegate
                {
                    if (line == "ACK")
                    { 
                        double ms = (DateTime.Now - tStart).TotalMilliseconds;
                        txtLatencyHistory.AppendText($"{ms}\r\n");
                        lblLatency.Text = ms.ToString("0.00");
                    }
                    else if (parts[0] == "D" && parts.Length >= 3)
                    {
                        lblLight.Text = parts[1];
                        int num = Convert.ToInt32(parts[2]);
                        num = ~num + 2;
                        lblMotion.Text = num.ToString();

                        chart1.Series[0].Points.Add(
                            double.Parse(parts[1])
                        );
                    }
                });
            }
            catch
            {
                // Ignore malformed serial data
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

        }
    }
}