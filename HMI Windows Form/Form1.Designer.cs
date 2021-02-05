namespace ReadSrial_Port_NEW_
{
    partial class Forma1
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
            this.textBOX_Show_Read = new System.Windows.Forms.TextBox();
            this.BTN_Send = new System.Windows.Forms.Button();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.buttonScan = new System.Windows.Forms.Button();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textHour = new System.Windows.Forms.TextBox();
            this.textMinute = new System.Windows.Forms.TextBox();
            this.textSecond = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBOX_Show_Read
            // 
            this.textBOX_Show_Read.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBOX_Show_Read.Cursor = System.Windows.Forms.Cursors.No;
            this.textBOX_Show_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.textBOX_Show_Read.Location = new System.Drawing.Point(39, 37);
            this.textBOX_Show_Read.Name = "textBOX_Show_Read";
            this.textBOX_Show_Read.Size = new System.Drawing.Size(475, 113);
            this.textBOX_Show_Read.TabIndex = 0;
            this.textBOX_Show_Read.Text = " ";
            this.textBOX_Show_Read.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_Send
            // 
            this.BTN_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BTN_Send.Location = new System.Drawing.Point(393, 274);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(121, 39);
            this.BTN_Send.TabIndex = 2;
            this.BTN_Send.Text = "Set Clock";
            this.BTN_Send.UseVisualStyleBackColor = true;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BTN_Start.Location = new System.Drawing.Point(393, 199);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(121, 39);
            this.BTN_Start.TabIndex = 3;
            this.BTN_Start.Text = "Connect";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(39, 199);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(128, 39);
            this.comboBox_Port.TabIndex = 5;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonScan
            // 
            this.buttonScan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonScan.Location = new System.Drawing.Point(216, 199);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(128, 39);
            this.buttonScan.TabIndex = 6;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // labelConfirm
            // 
            this.labelConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.labelConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelConfirm.Location = new System.Drawing.Point(12, 409);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(518, 23);
            this.labelConfirm.TabIndex = 7;
            this.labelConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Time :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(374, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "David Fauzi        / 13218043";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(371, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Feroz Fernando / 13218003";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(422, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kelompok 2";
            // 
            // textHour
            // 
            this.textHour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.textHour.Location = new System.Drawing.Point(71, 279);
            this.textHour.Name = "textHour";
            this.textHour.Size = new System.Drawing.Size(58, 34);
            this.textHour.TabIndex = 12;
            this.textHour.Text = "HH";
            this.textHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMinute
            // 
            this.textMinute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.textMinute.Location = new System.Drawing.Point(163, 279);
            this.textMinute.Name = "textMinute";
            this.textMinute.Size = new System.Drawing.Size(58, 34);
            this.textMinute.TabIndex = 13;
            this.textMinute.Text = "MM";
            this.textMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSecond
            // 
            this.textSecond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.textSecond.Location = new System.Drawing.Point(255, 279);
            this.textSecond.Name = "textSecond";
            this.textSecond.Size = new System.Drawing.Size(58, 34);
            this.textSecond.TabIndex = 14;
            this.textSecond.Text = "SS";
            this.textSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(135, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(227, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = ":";
            // 
            // buttonSync
            // 
            this.buttonSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSync.Location = new System.Drawing.Point(216, 356);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(121, 39);
            this.buttonSync.TabIndex = 17;
            this.buttonSync.Text = "Sync Time";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // Forma1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 518);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSecond);
            this.Controls.Add(this.textMinute);
            this.Controls.Add(this.textHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.comboBox_Port);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.BTN_Send);
            this.Controls.Add(this.textBOX_Show_Read);
            this.Name = "Forma1";
            this.Text = "Digital Clock HMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBOX_Show_Read;
        private System.Windows.Forms.Button BTN_Send;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textHour;
        private System.Windows.Forms.TextBox textMinute;
        private System.Windows.Forms.TextBox textSecond;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSync;
    }
}

