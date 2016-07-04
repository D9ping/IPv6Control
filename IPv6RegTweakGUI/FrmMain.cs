using System;
using System.Windows.Forms;

namespace IPv6RegTweakGUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void SetBitDisableComponent(int position, bool enabled)
        {
            const int numbits = 8;
            char[] binaryvalue = this.lblDisabledComponentBinary.Text.ToCharArray();
            if (binaryvalue.Length != numbits)
            {
                return;
            }

            if (enabled)
            {
                binaryvalue[position] = '1';
            }
            else
            {
                binaryvalue[position] = '0';
            }

            double num = 0;
            for (int p = 0; p < numbits; ++p)
            {
                if (binaryvalue[p] == '1')
                {
                    num += Math.Pow(2, p);
                }
            }

            this.lblDisabledComponentBinary.Text = new string(binaryvalue);
            string hexnum = ((int)num).ToString("X");
            this.lblDisabledComponentHEX.Text = "0x";
            if (hexnum.Length < 2) {
                this.lblDisabledComponentHEX.Text += "0";
            }

            this.lblDisabledComponentHEX.Text += hexnum;
        }

        private void chxDisableAllTransitionTechnologies_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox chx = (CheckBox)sender;
            SetBitDisableComponent(0, chx.Checked);
        }

        private void chxDisable6to4_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox chx = (CheckBox)sender;
            SetBitDisableComponent(1, chx.Checked);
        }

        private void chxDisableISATAP_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox chx = (CheckBox)sender;
            SetBitDisableComponent(2, chx.Checked);
        }

        private void chxDisableTeredo_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox chx = (CheckBox)sender;
            SetBitDisableComponent(3, chx.Checked);
        }

        private void chxDisableIPv6OnAllNotTunnels_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox chx = (CheckBox)sender;
            SetBitDisableComponent(4, chx.Checked);
        }

        private void chxPreferIPv4_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox chx = (CheckBox)sender;
            SetBitDisableComponent(5, chx.Checked);
        }

        private void chxDisableAllIpHttps_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox chx = (CheckBox)sender;
            SetBitDisableComponent(7, chx.Checked);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to write the new DisabledComponent DWORD hexdec. value: "+this.lblDisabledComponentHEX.Text+" to Windows registery? A reboot is required for change to be applied.", "Sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }


        }

        private void CheckboxesEnabledAll(bool enabled)
        {
            this.chxDisable6to4.Enabled = enabled;
            this.chxDisableAllIpHttps.Enabled = enabled;
            this.chxDisableAllTransitionTechnologies.Enabled = enabled;
            this.chxDisableIPv6OnAllNotTunnels.Enabled = enabled;
            this.chxDisableISATAP.Enabled = enabled;
            this.chxDisableTeredo.Enabled = enabled;
            this.chxPreferIPv4.Enabled = enabled;
        }

        private void CheckboxesCheckedAll(bool ischecked)
        {
            this.chxDisable6to4.Checked = ischecked;
            this.chxDisableAllIpHttps.Checked = ischecked;
            this.chxDisableAllTransitionTechnologies.Checked = ischecked;
            this.chxDisableIPv6OnAllNotTunnels.Checked = ischecked;
            this.chxDisableISATAP.Checked = ischecked;
            this.chxDisableTeredo.Checked = ischecked;
            this.chxPreferIPv4.Checked = ischecked;
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            this.CheckboxesEnabledAll(false);
            this.CheckboxesCheckedAll(false);
            this.CheckboxesEnabledAll(true);
        }
    }


}
