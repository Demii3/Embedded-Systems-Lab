namespace basta_po_ok
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Connection_Panel = new System.Windows.Forms.Panel();
            this.lblPorts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnectPort = new System.Windows.Forms.Button();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnectPort = new System.Windows.Forms.Button();
            this.Connection_Panel_Label = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Light_Panel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLight = new System.Windows.Forms.Label();
            this.Light_Label = new System.Windows.Forms.Label();
            this.Motion_Panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMotion = new System.Windows.Forms.Label();
            this.Motion_Label = new System.Windows.Forms.Label();
            this.Latency_Panel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLatency = new System.Windows.Forms.Label();
            this.Latency_Label = new System.Windows.Forms.Label();
            this.btnLedOff = new System.Windows.Forms.Button();
            this.lblLed = new System.Windows.Forms.Label();
            this.Latency_History_Panel = new System.Windows.Forms.Panel();
            this.txtLatencyHistory = new System.Windows.Forms.TextBox();
            this.LatencyHistory_Label = new System.Windows.Forms.Label();
            this.btnLedOn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.Connection_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Light_Panel.SuspendLayout();
            this.Motion_Panel.SuspendLayout();
            this.Latency_Panel.SuspendLayout();
            this.Latency_History_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connection_Panel
            // 
            this.Connection_Panel.BackColor = System.Drawing.Color.GhostWhite;
            this.Connection_Panel.Controls.Add(this.lblPorts);
            this.Connection_Panel.Controls.Add(this.label2);
            this.Connection_Panel.Controls.Add(this.btnDisconnectPort);
            this.Connection_Panel.Controls.Add(this.cmbPorts);
            this.Connection_Panel.Controls.Add(this.btnConnectPort);
            this.Connection_Panel.Controls.Add(this.Connection_Panel_Label);
            this.Connection_Panel.Location = new System.Drawing.Point(33, 22);
            this.Connection_Panel.Name = "Connection_Panel";
            this.Connection_Panel.Size = new System.Drawing.Size(339, 212);
            this.Connection_Panel.TabIndex = 1;
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.BackColor = System.Drawing.Color.Transparent;
            this.lblPorts.ForeColor = System.Drawing.Color.Red;
            this.lblPorts.Location = new System.Drawing.Point(109, 127);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(117, 16);
            this.lblPorts.TabIndex = 5;
            this.lblPorts.Text = "Port Disconnected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Port:";
            // 
            // btnDisconnectPort
            // 
            this.btnDisconnectPort.BackColor = System.Drawing.SystemColors.Window;
            this.btnDisconnectPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectPort.ForeColor = System.Drawing.Color.Indigo;
            this.btnDisconnectPort.Location = new System.Drawing.Point(176, 157);
            this.btnDisconnectPort.Name = "btnDisconnectPort";
            this.btnDisconnectPort.Size = new System.Drawing.Size(131, 28);
            this.btnDisconnectPort.TabIndex = 3;
            this.btnDisconnectPort.Text = "Disconnect Port";
            this.btnDisconnectPort.UseVisualStyleBackColor = false;
            this.btnDisconnectPort.Click += new System.EventHandler(this.btnDisconnectPort_Click);
            // 
            // cmbPorts
            // 
            this.cmbPorts.BackColor = System.Drawing.Color.Lavender;
            this.cmbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(39, 88);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(268, 24);
            this.cmbPorts.TabIndex = 2;
            // 
            // btnConnectPort
            // 
            this.btnConnectPort.BackColor = System.Drawing.Color.Indigo;
            this.btnConnectPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectPort.ForeColor = System.Drawing.Color.White;
            this.btnConnectPort.Location = new System.Drawing.Point(39, 157);
            this.btnConnectPort.Name = "btnConnectPort";
            this.btnConnectPort.Size = new System.Drawing.Size(121, 28);
            this.btnConnectPort.TabIndex = 1;
            this.btnConnectPort.Text = "Connect Port";
            this.btnConnectPort.UseVisualStyleBackColor = false;
            this.btnConnectPort.Click += new System.EventHandler(this.btnConnectPort_Click);
            // 
            // Connection_Panel_Label
            // 
            this.Connection_Panel_Label.AutoSize = true;
            this.Connection_Panel_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection_Panel_Label.ForeColor = System.Drawing.Color.Indigo;
            this.Connection_Panel_Label.Location = new System.Drawing.Point(34, 18);
            this.Connection_Panel_Label.Name = "Connection_Panel_Label";
            this.Connection_Panel_Label.Size = new System.Drawing.Size(183, 25);
            this.Connection_Panel_Label.TabIndex = 0;
            this.Connection_Panel_Label.Text = "Connection Panel";
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderlineColor = System.Drawing.Color.SandyBrown;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(33, 269);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series4.BackSecondaryColor = System.Drawing.Color.White;
            series4.BorderColor = System.Drawing.Color.Black;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Indigo;
            series4.LabelForeColor = System.Drawing.Color.Indigo;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.ShadowColor = System.Drawing.Color.Silver;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(986, 354);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Light_Panel
            // 
            this.Light_Panel.BackColor = System.Drawing.Color.White;
            this.Light_Panel.Controls.Add(this.label10);
            this.Light_Panel.Controls.Add(this.lblLight);
            this.Light_Panel.Controls.Add(this.Light_Label);
            this.Light_Panel.Location = new System.Drawing.Point(391, 22);
            this.Light_Panel.Name = "Light_Panel";
            this.Light_Panel.Size = new System.Drawing.Size(197, 213);
            this.Light_Panel.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(84, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "lux";
            // 
            // lblLight
            // 
            this.lblLight.AutoSize = true;
            this.lblLight.BackColor = System.Drawing.Color.Transparent;
            this.lblLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight.ForeColor = System.Drawing.Color.Indigo;
            this.lblLight.Location = new System.Drawing.Point(67, 88);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(32, 36);
            this.lblLight.TabIndex = 6;
            this.lblLight.Text = "0";
            // 
            // Light_Label
            // 
            this.Light_Label.AutoSize = true;
            this.Light_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Light_Label.ForeColor = System.Drawing.Color.Indigo;
            this.Light_Label.Location = new System.Drawing.Point(28, 18);
            this.Light_Label.Name = "Light_Label";
            this.Light_Label.Size = new System.Drawing.Size(59, 25);
            this.Light_Label.TabIndex = 6;
            this.Light_Label.Text = "Light";
            // 
            // Motion_Panel
            // 
            this.Motion_Panel.BackColor = System.Drawing.Color.GhostWhite;
            this.Motion_Panel.Controls.Add(this.label6);
            this.Motion_Panel.Controls.Add(this.lblMotion);
            this.Motion_Panel.Controls.Add(this.Motion_Label);
            this.Motion_Panel.Location = new System.Drawing.Point(607, 22);
            this.Motion_Panel.Name = "Motion_Panel";
            this.Motion_Panel.Size = new System.Drawing.Size(197, 213);
            this.Motion_Panel.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(63, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "detected";
            // 
            // lblMotion
            // 
            this.lblMotion.AutoSize = true;
            this.lblMotion.BackColor = System.Drawing.Color.Transparent;
            this.lblMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotion.ForeColor = System.Drawing.Color.Indigo;
            this.lblMotion.Location = new System.Drawing.Point(73, 88);
            this.lblMotion.Name = "lblMotion";
            this.lblMotion.Size = new System.Drawing.Size(32, 36);
            this.lblMotion.TabIndex = 6;
            this.lblMotion.Text = "0";
            // 
            // Motion_Label
            // 
            this.Motion_Label.AutoSize = true;
            this.Motion_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motion_Label.ForeColor = System.Drawing.Color.Indigo;
            this.Motion_Label.Location = new System.Drawing.Point(28, 18);
            this.Motion_Label.Name = "Motion_Label";
            this.Motion_Label.Size = new System.Drawing.Size(77, 25);
            this.Motion_Label.TabIndex = 6;
            this.Motion_Label.Text = "Motion";
            // 
            // Latency_Panel
            // 
            this.Latency_Panel.BackColor = System.Drawing.Color.White;
            this.Latency_Panel.Controls.Add(this.label9);
            this.Latency_Panel.Controls.Add(this.lblLatency);
            this.Latency_Panel.Controls.Add(this.Latency_Label);
            this.Latency_Panel.Location = new System.Drawing.Point(822, 22);
            this.Latency_Panel.Name = "Latency_Panel";
            this.Latency_Panel.Size = new System.Drawing.Size(197, 213);
            this.Latency_Panel.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(84, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "ms";
            // 
            // lblLatency
            // 
            this.lblLatency.AutoSize = true;
            this.lblLatency.BackColor = System.Drawing.Color.Transparent;
            this.lblLatency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatency.ForeColor = System.Drawing.Color.Indigo;
            this.lblLatency.Location = new System.Drawing.Point(66, 88);
            this.lblLatency.Name = "lblLatency";
            this.lblLatency.Size = new System.Drawing.Size(32, 36);
            this.lblLatency.TabIndex = 6;
            this.lblLatency.Text = "0";
            // 
            // Latency_Label
            // 
            this.Latency_Label.AutoSize = true;
            this.Latency_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latency_Label.ForeColor = System.Drawing.Color.Indigo;
            this.Latency_Label.Location = new System.Drawing.Point(28, 18);
            this.Latency_Label.Name = "Latency_Label";
            this.Latency_Label.Size = new System.Drawing.Size(88, 25);
            this.Latency_Label.TabIndex = 6;
            this.Latency_Label.Text = "Latency";
            // 
            // btnLedOff
            // 
            this.btnLedOff.BackColor = System.Drawing.Color.IndianRed;
            this.btnLedOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedOff.ForeColor = System.Drawing.Color.White;
            this.btnLedOff.Location = new System.Drawing.Point(1146, 543);
            this.btnLedOff.Name = "btnLedOff";
            this.btnLedOff.Size = new System.Drawing.Size(108, 43);
            this.btnLedOff.TabIndex = 7;
            this.btnLedOff.Text = "LED OFF";
            this.btnLedOff.UseVisualStyleBackColor = false;
            this.btnLedOff.Click += new System.EventHandler(this.btnLedOff_Click);
            // 
            // lblLed
            // 
            this.lblLed.AutoSize = true;
            this.lblLed.BackColor = System.Drawing.Color.Transparent;
            this.lblLed.ForeColor = System.Drawing.Color.Red;
            this.lblLed.Location = new System.Drawing.Point(1112, 598);
            this.lblLed.Name = "lblLed";
            this.lblLed.Size = new System.Drawing.Size(75, 16);
            this.lblLed.TabIndex = 6;
            this.lblLed.Text = "LED is OFF";
            // 
            // Latency_History_Panel
            // 
            this.Latency_History_Panel.Controls.Add(this.txtLatencyHistory);
            this.Latency_History_Panel.Controls.Add(this.LatencyHistory_Label);
            this.Latency_History_Panel.Location = new System.Drawing.Point(1037, 22);
            this.Latency_History_Panel.Name = "Latency_History_Panel";
            this.Latency_History_Panel.Size = new System.Drawing.Size(217, 501);
            this.Latency_History_Panel.TabIndex = 10;
            // 
            // txtLatencyHistory
            // 
            this.txtLatencyHistory.BackColor = System.Drawing.Color.Lavender;
            this.txtLatencyHistory.Location = new System.Drawing.Point(17, 66);
            this.txtLatencyHistory.Multiline = true;
            this.txtLatencyHistory.Name = "txtLatencyHistory";
            this.txtLatencyHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLatencyHistory.Size = new System.Drawing.Size(185, 405);
            this.txtLatencyHistory.TabIndex = 9;
            // 
            // LatencyHistory_Label
            // 
            this.LatencyHistory_Label.AutoSize = true;
            this.LatencyHistory_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatencyHistory_Label.ForeColor = System.Drawing.Color.Indigo;
            this.LatencyHistory_Label.Location = new System.Drawing.Point(12, 18);
            this.LatencyHistory_Label.Name = "LatencyHistory_Label";
            this.LatencyHistory_Label.Size = new System.Drawing.Size(161, 25);
            this.LatencyHistory_Label.TabIndex = 8;
            this.LatencyHistory_Label.Text = "Latency History";
            // 
            // btnLedOn
            // 
            this.btnLedOn.BackColor = System.Drawing.Color.Green;
            this.btnLedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedOn.ForeColor = System.Drawing.Color.White;
            this.btnLedOn.Location = new System.Drawing.Point(1037, 543);
            this.btnLedOn.Name = "btnLedOn";
            this.btnLedOn.Size = new System.Drawing.Size(103, 43);
            this.btnLedOn.TabIndex = 11;
            this.btnLedOn.Text = "LED ON";
            this.btnLedOn.UseVisualStyleBackColor = false;
            this.btnLedOn.Click += new System.EventHandler(this.btnLedOn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Indigo;
            this.btnClear.Location = new System.Drawing.Point(878, 324);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Chart";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 634);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLedOn);
            this.Controls.Add(this.Latency_History_Panel);
            this.Controls.Add(this.lblLed);
            this.Controls.Add(this.btnLedOff);
            this.Controls.Add(this.Latency_Panel);
            this.Controls.Add(this.Motion_Panel);
            this.Controls.Add(this.Light_Panel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Connection_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Connection_Panel.ResumeLayout(false);
            this.Connection_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Light_Panel.ResumeLayout(false);
            this.Light_Panel.PerformLayout();
            this.Motion_Panel.ResumeLayout(false);
            this.Motion_Panel.PerformLayout();
            this.Latency_Panel.ResumeLayout(false);
            this.Latency_Panel.PerformLayout();
            this.Latency_History_Panel.ResumeLayout(false);
            this.Latency_History_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Connection_Panel;
        private System.Windows.Forms.Button btnConnectPort;
        private System.Windows.Forms.Label Connection_Panel_Label;
        private System.Windows.Forms.Button btnDisconnectPort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.Panel Light_Panel;
        private System.Windows.Forms.Label lblLight;
        private System.Windows.Forms.Label Light_Label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel Motion_Panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMotion;
        private System.Windows.Forms.Label Motion_Label;
        private System.Windows.Forms.Panel Latency_Panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLatency;
        private System.Windows.Forms.Label Latency_Label;
        private System.Windows.Forms.Button btnLedOff;
        private System.Windows.Forms.Label lblLed;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Panel Latency_History_Panel;
        private System.Windows.Forms.TextBox txtLatencyHistory;
        private System.Windows.Forms.Label LatencyHistory_Label;
        private System.Windows.Forms.Button btnLedOn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnClear;
    }
}

