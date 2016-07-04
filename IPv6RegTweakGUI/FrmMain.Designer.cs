namespace IPv6RegTweakGUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.chxDisableAllTransitionTechnologies = new System.Windows.Forms.CheckBox();
            this.lblTextDisabledComponent = new System.Windows.Forms.Label();
            this.chxDisable6to4 = new System.Windows.Forms.CheckBox();
            this.chxDisableISATAP = new System.Windows.Forms.CheckBox();
            this.chxDisableTeredo = new System.Windows.Forms.CheckBox();
            this.chxDisableIPv6OnAllNotTunnels = new System.Windows.Forms.CheckBox();
            this.chxPreferIPv4 = new System.Windows.Forms.CheckBox();
            this.chxDisableAllIpHttps = new System.Windows.Forms.CheckBox();
            this.lblDisabledComponentHEX = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chxDisableAllTransitionTechnologies
            // 
            this.chxDisableAllTransitionTechnologies.AutoSize = true;
            this.chxDisableAllTransitionTechnologies.ForeColor = System.Drawing.Color.White;
            this.chxDisableAllTransitionTechnologies.Location = new System.Drawing.Point(25, 21);
            this.chxDisableAllTransitionTechnologies.Name = "chxDisableAllTransitionTechnologies";
            this.chxDisableAllTransitionTechnologies.Size = new System.Drawing.Size(394, 18);
            this.chxDisableAllTransitionTechnologies.TabIndex = 0;
            this.chxDisableAllTransitionTechnologies.Text = "Disable all tunnel interfaces, including: ISATAP, 6to4, and Teredo tunnels.";
            this.chxDisableAllTransitionTechnologies.UseCompatibleTextRendering = true;
            this.chxDisableAllTransitionTechnologies.UseVisualStyleBackColor = true;
            this.chxDisableAllTransitionTechnologies.CheckedChanged += new System.EventHandler(this.chxDisableAllTransitionTechnologies_CheckedChanged);
            // 
            // lblTextDisabledComponent
            // 
            this.lblTextDisabledComponent.AutoSize = true;
            this.lblTextDisabledComponent.CausesValidation = false;
            this.lblTextDisabledComponent.ForeColor = System.Drawing.Color.White;
            this.lblTextDisabledComponent.Location = new System.Drawing.Point(46, 208);
            this.lblTextDisabledComponent.Name = "lblTextDisabledComponent";
            this.lblTextDisabledComponent.Size = new System.Drawing.Size(213, 17);
            this.lblTextDisabledComponent.TabIndex = 1;
            this.lblTextDisabledComponent.Text = "New DisabledComponent DWORD value:";
            this.lblTextDisabledComponent.UseCompatibleTextRendering = true;
            // 
            // chxDisable6to4
            // 
            this.chxDisable6to4.AutoSize = true;
            this.chxDisable6to4.ForeColor = System.Drawing.Color.White;
            this.chxDisable6to4.Location = new System.Drawing.Point(25, 44);
            this.chxDisable6to4.Name = "chxDisable6to4";
            this.chxDisable6to4.Size = new System.Drawing.Size(191, 18);
            this.chxDisable6to4.TabIndex = 3;
            this.chxDisable6to4.Text = "Disable all 6to4-based interfaces.";
            this.chxDisable6to4.UseCompatibleTextRendering = true;
            this.chxDisable6to4.UseVisualStyleBackColor = true;
            this.chxDisable6to4.CheckedChanged += new System.EventHandler(this.chxDisable6to4_CheckedChanged);
            // 
            // chxDisableISATAP
            // 
            this.chxDisableISATAP.AutoSize = true;
            this.chxDisableISATAP.ForeColor = System.Drawing.Color.White;
            this.chxDisableISATAP.Location = new System.Drawing.Point(25, 67);
            this.chxDisableISATAP.Name = "chxDisableISATAP";
            this.chxDisableISATAP.Size = new System.Drawing.Size(209, 18);
            this.chxDisableISATAP.TabIndex = 4;
            this.chxDisableISATAP.Text = "Disable all ISATAP-based interfaces.";
            this.chxDisableISATAP.UseCompatibleTextRendering = true;
            this.chxDisableISATAP.UseVisualStyleBackColor = true;
            this.chxDisableISATAP.CheckedChanged += new System.EventHandler(this.chxDisableISATAP_CheckedChanged);
            // 
            // chxDisableTeredo
            // 
            this.chxDisableTeredo.AutoSize = true;
            this.chxDisableTeredo.ForeColor = System.Drawing.Color.White;
            this.chxDisableTeredo.Location = new System.Drawing.Point(25, 90);
            this.chxDisableTeredo.Name = "chxDisableTeredo";
            this.chxDisableTeredo.Size = new System.Drawing.Size(204, 18);
            this.chxDisableTeredo.TabIndex = 5;
            this.chxDisableTeredo.Text = "Disable all Teredo-based interfaces.";
            this.chxDisableTeredo.UseCompatibleTextRendering = true;
            this.chxDisableTeredo.UseVisualStyleBackColor = true;
            this.chxDisableTeredo.CheckedChanged += new System.EventHandler(this.chxDisableTeredo_CheckedChanged);
            // 
            // chxDisableIPv6OnAllNotTunnels
            // 
            this.chxDisableIPv6OnAllNotTunnels.AutoSize = true;
            this.chxDisableIPv6OnAllNotTunnels.ForeColor = System.Drawing.Color.White;
            this.chxDisableIPv6OnAllNotTunnels.Location = new System.Drawing.Point(25, 113);
            this.chxDisableIPv6OnAllNotTunnels.Name = "chxDisableIPv6OnAllNotTunnels";
            this.chxDisableIPv6OnAllNotTunnels.Size = new System.Drawing.Size(430, 31);
            this.chxDisableIPv6OnAllNotTunnels.TabIndex = 6;
            this.chxDisableIPv6OnAllNotTunnels.Text = "Disable disable IPv6 over all non-tunnel interfaces, including LAN interfaces and" +
    "\r\n Point-to-Point Protocol (PPP)-based interfaces. (not recommeded)";
            this.chxDisableIPv6OnAllNotTunnels.UseCompatibleTextRendering = true;
            this.chxDisableIPv6OnAllNotTunnels.UseVisualStyleBackColor = true;
            this.chxDisableIPv6OnAllNotTunnels.CheckedChanged += new System.EventHandler(this.chxDisableIPv6OnAllNotTunnels_CheckedChanged);
            // 
            // chxPreferIPv4
            // 
            this.chxPreferIPv4.AutoSize = true;
            this.chxPreferIPv4.ForeColor = System.Drawing.Color.White;
            this.chxPreferIPv4.Location = new System.Drawing.Point(25, 149);
            this.chxPreferIPv4.Name = "chxPreferIPv4";
            this.chxPreferIPv4.Size = new System.Drawing.Size(366, 18);
            this.chxPreferIPv4.TabIndex = 7;
            this.chxPreferIPv4.Text = "Prefer IPv4 to IPv6 when attempting connections. (not recommeded)";
            this.chxPreferIPv4.UseCompatibleTextRendering = true;
            this.chxPreferIPv4.UseVisualStyleBackColor = true;
            this.chxPreferIPv4.CheckedChanged += new System.EventHandler(this.chxPreferIPv4_CheckedChanged);
            // 
            // chxDisableAllIpHttps
            // 
            this.chxDisableAllIpHttps.AutoSize = true;
            this.chxDisableAllIpHttps.ForeColor = System.Drawing.Color.White;
            this.chxDisableAllIpHttps.Location = new System.Drawing.Point(25, 172);
            this.chxDisableAllIpHttps.Name = "chxDisableAllIpHttps";
            this.chxDisableAllIpHttps.Size = new System.Drawing.Size(220, 18);
            this.chxDisableAllIpHttps.TabIndex = 8;
            this.chxDisableAllIpHttps.Text = "Disable all IP-HTTPS-based interfaces.";
            this.chxDisableAllIpHttps.UseCompatibleTextRendering = true;
            this.chxDisableAllIpHttps.UseVisualStyleBackColor = true;
            this.chxDisableAllIpHttps.CheckedChanged += new System.EventHandler(this.chxDisableAllIpHttps_CheckedChanged);
            // 
            // lblDisabledComponentHEX
            // 
            this.lblDisabledComponentHEX.AutoSize = true;
            this.lblDisabledComponentHEX.ForeColor = System.Drawing.Color.White;
            this.lblDisabledComponentHEX.Location = new System.Drawing.Point(265, 208);
            this.lblDisabledComponentHEX.Name = "lblDisabledComponentHEX";
            this.lblDisabledComponentHEX.Size = new System.Drawing.Size(29, 17);
            this.lblDisabledComponentHEX.TabIndex = 9;
            this.lblDisabledComponentHEX.Text = "0x00";
            this.lblDisabledComponentHEX.UseCompatibleTextRendering = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(251, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 32);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save settings";
            this.btnSave.UseCompatibleTextRendering = true;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUncheckAll.ForeColor = System.Drawing.Color.White;
            this.btnUncheckAll.Location = new System.Drawing.Point(46, 228);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(199, 32);
            this.btnUncheckAll.TabIndex = 11;
            this.btnUncheckAll.Text = "&Uncheck all";
            this.btnUncheckAll.UseCompatibleTextRendering = true;
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDisabledComponentHEX);
            this.Controls.Add(this.chxDisableAllIpHttps);
            this.Controls.Add(this.chxPreferIPv4);
            this.Controls.Add(this.chxDisableIPv6OnAllNotTunnels);
            this.Controls.Add(this.chxDisableTeredo);
            this.Controls.Add(this.chxDisableISATAP);
            this.Controls.Add(this.chxDisable6to4);
            this.Controls.Add(this.lblTextDisabledComponent);
            this.Controls.Add(this.chxDisableAllTransitionTechnologies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "IPv6RegTweakGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chxDisableAllTransitionTechnologies;
        private System.Windows.Forms.Label lblTextDisabledComponent;
        private System.Windows.Forms.CheckBox chxDisable6to4;
        private System.Windows.Forms.CheckBox chxDisableISATAP;
        private System.Windows.Forms.CheckBox chxDisableTeredo;
        private System.Windows.Forms.CheckBox chxDisableIPv6OnAllNotTunnels;
        private System.Windows.Forms.CheckBox chxPreferIPv4;
        private System.Windows.Forms.CheckBox chxDisableAllIpHttps;
        private System.Windows.Forms.Label lblDisabledComponentHEX;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUncheckAll;
    }
}

