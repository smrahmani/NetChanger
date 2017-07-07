﻿namespace NetChanger
{
    partial class mainForm
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
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ifaceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dhcpRbn = new System.Windows.Forms.RadioButton();
            this.staticRbn = new System.Windows.Forms.RadioButton();
            this.gatewayTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.netmaskTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ifaceTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.gatewayTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.netmaskTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addressTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Static IP";
            // 
            // ifaceTxt
            // 
            this.ifaceTxt.Location = new System.Drawing.Point(178, 36);
            this.ifaceTxt.Name = "ifaceTxt";
            this.ifaceTxt.Size = new System.Drawing.Size(165, 29);
            this.ifaceTxt.TabIndex = 8;
            this.ifaceTxt.Text = "Wi-Fi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interface Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dhcpRbn);
            this.panel2.Controls.Add(this.staticRbn);
            this.panel2.Location = new System.Drawing.Point(394, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 84);
            this.panel2.TabIndex = 6;
            // 
            // dhcpRbn
            // 
            this.dhcpRbn.AutoSize = true;
            this.dhcpRbn.Location = new System.Drawing.Point(14, 45);
            this.dhcpRbn.Name = "dhcpRbn";
            this.dhcpRbn.Size = new System.Drawing.Size(93, 29);
            this.dhcpRbn.TabIndex = 1;
            this.dhcpRbn.Text = "&DHCP";
            this.dhcpRbn.UseVisualStyleBackColor = true;
            // 
            // staticRbn
            // 
            this.staticRbn.AutoSize = true;
            this.staticRbn.Checked = true;
            this.staticRbn.Location = new System.Drawing.Point(14, 12);
            this.staticRbn.Name = "staticRbn";
            this.staticRbn.Size = new System.Drawing.Size(86, 29);
            this.staticRbn.TabIndex = 0;
            this.staticRbn.TabStop = true;
            this.staticRbn.Text = "&Static";
            this.staticRbn.UseVisualStyleBackColor = true;
            // 
            // gatewayTxt
            // 
            this.gatewayTxt.Location = new System.Drawing.Point(178, 160);
            this.gatewayTxt.Name = "gatewayTxt";
            this.gatewayTxt.Size = new System.Drawing.Size(165, 29);
            this.gatewayTxt.TabIndex = 5;
            this.gatewayTxt.Text = "172.16.16.9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Gateway";
            // 
            // netmaskTxt
            // 
            this.netmaskTxt.Location = new System.Drawing.Point(178, 119);
            this.netmaskTxt.Name = "netmaskTxt";
            this.netmaskTxt.Size = new System.Drawing.Size(165, 29);
            this.netmaskTxt.TabIndex = 3;
            this.netmaskTxt.Text = "255.255.252.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Netmask";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(178, 78);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(165, 29);
            this.addressTxt.TabIndex = 1;
            this.addressTxt.Text = "172.16.17.4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Address";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(11, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 74);
            this.panel1.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Location = new System.Drawing.Point(336, 20);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(119, 42);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(461, 20);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 42);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(625, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(26, 387);
            this.Name = "mainForm";
            this.Text = "NetChanger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox netmaskTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gatewayTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton dhcpRbn;
        private System.Windows.Forms.RadioButton staticRbn;
        private System.Windows.Forms.TextBox ifaceTxt;
        private System.Windows.Forms.Label label4;
    }
}

