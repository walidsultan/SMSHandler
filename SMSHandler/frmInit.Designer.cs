namespace SMSServer
{
    partial class frmInit
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
            this.txtCurrentCredit = new System.Windows.Forms.TextBox();
            this.txtSMSCost = new System.Windows.Forms.TextBox();
            this.txtSMSDeleteThreshold = new System.Windows.Forms.TextBox();
            this.txtCreditStopLimit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epSettings = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSelectedDestinations = new System.Windows.Forms.Label();
            this.lnkEditDestinations = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.epSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurrentCredit
            // 
            this.txtCurrentCredit.Location = new System.Drawing.Point(156, 38);
            this.txtCurrentCredit.Name = "txtCurrentCredit";
            this.txtCurrentCredit.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentCredit.TabIndex = 0;
            // 
            // txtSMSCost
            // 
            this.txtSMSCost.Location = new System.Drawing.Point(156, 76);
            this.txtSMSCost.Name = "txtSMSCost";
            this.txtSMSCost.Size = new System.Drawing.Size(100, 20);
            this.txtSMSCost.TabIndex = 1;
            // 
            // txtSMSDeleteThreshold
            // 
            this.txtSMSDeleteThreshold.Location = new System.Drawing.Point(156, 114);
            this.txtSMSDeleteThreshold.Name = "txtSMSDeleteThreshold";
            this.txtSMSDeleteThreshold.Size = new System.Drawing.Size(100, 20);
            this.txtSMSDeleteThreshold.TabIndex = 2;
            // 
            // txtCreditStopLimit
            // 
            this.txtCreditStopLimit.Location = new System.Drawing.Point(156, 152);
            this.txtCreditStopLimit.Name = "txtCreditStopLimit";
            this.txtCreditStopLimit.Size = new System.Drawing.Size(100, 20);
            this.txtCreditStopLimit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Credit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SMS Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SMS Delete Threshold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Credit Stop Limit";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(156, 298);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epSettings
            // 
            this.epSettings.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Com";
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(156, 189);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(100, 20);
            this.txtCom.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Destination";
            // 
            // lblSelectedDestinations
            // 
            this.lblSelectedDestinations.AutoSize = true;
            this.lblSelectedDestinations.BackColor = System.Drawing.Color.White;
            this.lblSelectedDestinations.Location = new System.Drawing.Point(156, 227);
            this.lblSelectedDestinations.Name = "lblSelectedDestinations";
            this.lblSelectedDestinations.Padding = new System.Windows.Forms.Padding(5);
            this.lblSelectedDestinations.Size = new System.Drawing.Size(10, 23);
            this.lblSelectedDestinations.TabIndex = 14;
            // 
            // lnkEditDestinations
            // 
            this.lnkEditDestinations.AutoSize = true;
            this.lnkEditDestinations.Location = new System.Drawing.Point(173, 226);
            this.lnkEditDestinations.Name = "lnkEditDestinations";
            this.lnkEditDestinations.Size = new System.Drawing.Size(25, 13);
            this.lnkEditDestinations.TabIndex = 15;
            this.lnkEditDestinations.TabStop = true;
            this.lnkEditDestinations.Text = "Edit";
            this.lnkEditDestinations.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditDestinations_LinkClicked);
            // 
            // frmInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 361);
            this.Controls.Add(this.lnkEditDestinations);
            this.Controls.Add(this.lblSelectedDestinations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCreditStopLimit);
            this.Controls.Add(this.txtSMSDeleteThreshold);
            this.Controls.Add(this.txtSMSCost);
            this.Controls.Add(this.txtCurrentCredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initialize";
            this.Load += new System.EventHandler(this.frmInit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentCredit;
        private System.Windows.Forms.TextBox txtSMSCost;
        private System.Windows.Forms.TextBox txtSMSDeleteThreshold;
        private System.Windows.Forms.TextBox txtCreditStopLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSelectedDestinations;
        private System.Windows.Forms.LinkLabel lnkEditDestinations;
    }
}