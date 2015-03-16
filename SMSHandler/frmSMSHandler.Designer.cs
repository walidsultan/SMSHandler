namespace SMSServer
{
    partial class frmSMSHandler
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentCredit = new System.Windows.Forms.Label();
            this.msSMSHandler = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableAutoDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSendSMS = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.lblReceivedSms = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSentSms = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tReceiveSMS = new System.Windows.Forms.Timer(this.components);
            this.msSMSHandler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Credit";
            // 
            // lblCurrentCredit
            // 
            this.lblCurrentCredit.AutoSize = true;
            this.lblCurrentCredit.BackColor = System.Drawing.Color.White;
            this.lblCurrentCredit.Location = new System.Drawing.Point(205, 56);
            this.lblCurrentCredit.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentCredit.Name = "lblCurrentCredit";
            this.lblCurrentCredit.Padding = new System.Windows.Forms.Padding(10);
            this.lblCurrentCredit.Size = new System.Drawing.Size(20, 33);
            this.lblCurrentCredit.TabIndex = 1;
            // 
            // msSMSHandler
            // 
            this.msSMSHandler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msSMSHandler.Location = new System.Drawing.Point(0, 0);
            this.msSMSHandler.Name = "msSMSHandler";
            this.msSMSHandler.Size = new System.Drawing.Size(372, 24);
            this.msSMSHandler.TabIndex = 2;
            this.msSMSHandler.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCreditToolStripMenuItem,
            this.disableAutoDeleteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setCreditToolStripMenuItem
            // 
            this.setCreditToolStripMenuItem.Name = "setCreditToolStripMenuItem";
            this.setCreditToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.setCreditToolStripMenuItem.Text = "Set Credit";
            this.setCreditToolStripMenuItem.Click += new System.EventHandler(this.setCreditToolStripMenuItem_Click);
            // 
            // disableAutoDeleteToolStripMenuItem
            // 
            this.disableAutoDeleteToolStripMenuItem.Name = "disableAutoDeleteToolStripMenuItem";
            this.disableAutoDeleteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.disableAutoDeleteToolStripMenuItem.Text = "Disable Auto Delete";
            this.disableAutoDeleteToolStripMenuItem.Click += new System.EventHandler(this.disableAutoDeleteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tSendSMS
            // 
            this.tSendSMS.Interval = 2000;
            this.tSendSMS.Tick += new System.EventHandler(this.tSendSMS_Tick);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(39, 33);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;
            // 
            // lblReceivedSms
            // 
            this.lblReceivedSms.AutoSize = true;
            this.lblReceivedSms.BackColor = System.Drawing.Color.White;
            this.lblReceivedSms.Location = new System.Drawing.Point(141, 106);
            this.lblReceivedSms.Margin = new System.Windows.Forms.Padding(0);
            this.lblReceivedSms.Name = "lblReceivedSms";
            this.lblReceivedSms.Padding = new System.Windows.Forms.Padding(10);
            this.lblReceivedSms.Size = new System.Drawing.Size(20, 33);
            this.lblReceivedSms.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Received SMS";
            // 
            // lblSentSms
            // 
            this.lblSentSms.AutoSize = true;
            this.lblSentSms.BackColor = System.Drawing.Color.White;
            this.lblSentSms.Location = new System.Drawing.Point(283, 106);
            this.lblSentSms.Margin = new System.Windows.Forms.Padding(0);
            this.lblSentSms.Name = "lblSentSms";
            this.lblSentSms.Padding = new System.Windows.Forms.Padding(10);
            this.lblSentSms.Size = new System.Drawing.Size(20, 33);
            this.lblSentSms.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sent SMS";
            // 
            // tReceiveSMS
            // 
            this.tReceiveSMS.Interval = 2000;
            this.tReceiveSMS.Tick += new System.EventHandler(this.tReceiveSMS_Tick);
            // 
            // frmSMSHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 169);
            this.Controls.Add(this.lblSentSms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblReceivedSms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCurrentCredit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msSMSHandler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msSMSHandler;
            this.MaximizeBox = false;
            this.Name = "frmSMSHandler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Server";
            this.Load += new System.EventHandler(this.frmSMSHandler_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSMSHandler_FormClosed);
            this.msSMSHandler.ResumeLayout(false);
            this.msSMSHandler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentCredit;
        private System.Windows.Forms.MenuStrip msSMSHandler;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer tSendSMS;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblReceivedSms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSentSms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tReceiveSMS;
        private System.Windows.Forms.ToolStripMenuItem disableAutoDeleteToolStripMenuItem;
    }
}

