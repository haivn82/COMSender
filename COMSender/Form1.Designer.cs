namespace COMSender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnDisconnectCOM = new System.Windows.Forms.Button();
            this.lbCPUName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbPCName = new System.Windows.Forms.Label();
            this.lbCPUUsage = new System.Windows.Forms.Label();
            this.lbBatSpecs = new System.Windows.Forms.Label();
            this.lbRAMUse = new System.Windows.Forms.Label();
            this.lbCPUSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCOMPorts = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.grpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.lbStatus);
            this.grpData.Controls.Add(this.btnDisconnectCOM);
            this.grpData.Controls.Add(this.lbCPUName);
            this.grpData.Controls.Add(this.label8);
            this.grpData.Controls.Add(this.btnSend);
            this.grpData.Controls.Add(this.lbPCName);
            this.grpData.Controls.Add(this.lbCPUUsage);
            this.grpData.Controls.Add(this.lbBatSpecs);
            this.grpData.Controls.Add(this.lbRAMUse);
            this.grpData.Controls.Add(this.lbCPUSpeed);
            this.grpData.Controls.Add(this.label5);
            this.grpData.Controls.Add(this.label6);
            this.grpData.Controls.Add(this.label4);
            this.grpData.Controls.Add(this.label3);
            this.grpData.Controls.Add(this.label2);
            this.grpData.Controls.Add(this.label1);
            this.grpData.Controls.Add(this.cmbCOMPorts);
            this.grpData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpData.Location = new System.Drawing.Point(13, 13);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(478, 311);
            this.grpData.TabIndex = 0;
            this.grpData.TabStop = false;
            this.grpData.Text = "Click on Any Option";
            // 
            // btnDisconnectCOM
            // 
            this.btnDisconnectCOM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectCOM.Location = new System.Drawing.Point(368, 99);
            this.btnDisconnectCOM.Name = "btnDisconnectCOM";
            this.btnDisconnectCOM.Size = new System.Drawing.Size(104, 29);
            this.btnDisconnectCOM.TabIndex = 16;
            this.btnDisconnectCOM.Text = "Disconnect COM";
            this.btnDisconnectCOM.UseVisualStyleBackColor = true;
            // 
            // lbCPUName
            // 
            this.lbCPUName.AutoSize = true;
            this.lbCPUName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCPUName.Location = new System.Drawing.Point(126, 238);
            this.lbCPUName.Name = "lbCPUName";
            this.lbCPUName.Size = new System.Drawing.Size(75, 21);
            this.lbCPUName.TabIndex = 15;
            this.lbCPUName.Text = "PC Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "CPU Name";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(368, 64);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 29);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send to COM";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lbPCName
            // 
            this.lbPCName.AutoSize = true;
            this.lbPCName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPCName.Location = new System.Drawing.Point(126, 208);
            this.lbPCName.Name = "lbPCName";
            this.lbPCName.Size = new System.Drawing.Size(75, 21);
            this.lbPCName.TabIndex = 12;
            this.lbPCName.Text = "PC Name";
            // 
            // lbCPUUsage
            // 
            this.lbCPUUsage.AutoSize = true;
            this.lbCPUUsage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCPUUsage.Location = new System.Drawing.Point(126, 118);
            this.lbCPUUsage.Name = "lbCPUUsage";
            this.lbCPUUsage.Size = new System.Drawing.Size(87, 21);
            this.lbCPUUsage.TabIndex = 11;
            this.lbCPUUsage.Text = "CPU Usage";
            // 
            // lbBatSpecs
            // 
            this.lbBatSpecs.AutoSize = true;
            this.lbBatSpecs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbBatSpecs.Location = new System.Drawing.Point(126, 178);
            this.lbBatSpecs.Name = "lbBatSpecs";
            this.lbBatSpecs.Size = new System.Drawing.Size(103, 21);
            this.lbBatSpecs.TabIndex = 10;
            this.lbBatSpecs.Text = "Battery Specs";
            // 
            // lbRAMUse
            // 
            this.lbRAMUse.AutoSize = true;
            this.lbRAMUse.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbRAMUse.Location = new System.Drawing.Point(126, 148);
            this.lbRAMUse.Name = "lbRAMUse";
            this.lbRAMUse.Size = new System.Drawing.Size(74, 21);
            this.lbRAMUse.TabIndex = 9;
            this.lbRAMUse.Text = "RAM Use";
            // 
            // lbCPUSpeed
            // 
            this.lbCPUSpeed.AutoSize = true;
            this.lbCPUSpeed.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCPUSpeed.Location = new System.Drawing.Point(126, 88);
            this.lbCPUSpeed.Name = "lbCPUSpeed";
            this.lbCPUSpeed.Size = new System.Drawing.Size(87, 21);
            this.lbCPUSpeed.TabIndex = 8;
            this.lbCPUSpeed.Text = "CPU Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "PC Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "CPU Usage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Battery Specs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "RAM Use";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPU Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Ports";
            // 
            // cmbCOMPorts
            // 
            this.cmbCOMPorts.FormattingEnabled = true;
            this.cmbCOMPorts.Location = new System.Drawing.Point(97, 29);
            this.cmbCOMPorts.Name = "cmbCOMPorts";
            this.cmbCOMPorts.Size = new System.Drawing.Size(375, 29);
            this.cmbCOMPorts.TabIndex = 0;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbStatus.Location = new System.Drawing.Point(6, 287);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(135, 21);
            this.lbStatus.TabIndex = 17;
            this.lbStatus.Text = "Connection Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 336);
            this.Controls.Add(this.grpData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "COM Sender";
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCOMPorts;
        private System.Windows.Forms.Label lbPCName;
        private System.Windows.Forms.Label lbCPUUsage;
        private System.Windows.Forms.Label lbBatSpecs;
        private System.Windows.Forms.Label lbRAMUse;
        private System.Windows.Forms.Label lbCPUSpeed;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbCPUName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDisconnectCOM;
        private System.Windows.Forms.Label lbStatus;
    }
}

