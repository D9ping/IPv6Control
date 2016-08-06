using System;
using System.Windows.Forms;

namespace IPv6Control
{
    public partial class FrmMain : Form
    {
        private DisabledComponentValue disabledComponentValue;

        /// <summary>
        /// Creating a new instance of FrmMain class.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            this.disabledComponentValue = new DisabledComponentValue();
            this.Text = Program.AssemblyTitle + " v" + Program.AssemblyVersion;
            if (this.disabledComponentValue.LoadFromRegisteryValue())
            {
                this.DisplayNewDisabledComponentValue();
                this.SetCheckboxesByDisabledComponentValue();
            }
            else
            {
                MessageBox.Show("Could not load current settings.\r\nAdministrator rights are required to read to the registery key.");
            }

            this.disabledComponentValue.DoCalculateValue = true;
        }

        private void DisplayNewDisabledComponentValue()
        {
            this.lblDisabledComponentHEX.Text = this.disabledComponentValue.GetHexdecValueStr();
        }

        private void chxDisableAllTransitionTechnologies_CheckedChanged(object sender, System.EventArgs e)
        {
            this.disabledComponentValue.DisableAllTransitionTechnologies = this.chxDisableAllTransitionTechnologies.Checked;
            this.DisplayNewDisabledComponentValue();
        }

        private void chxDisable6to4_CheckedChanged(object sender, System.EventArgs e)
        {
            this.disabledComponentValue.Disable6to4 = this.chxDisable6to4.Checked;
            this.DisplayNewDisabledComponentValue();
        }

        private void chxDisableISATAP_CheckedChanged(object sender, System.EventArgs e)
        {
            this.disabledComponentValue.DisableISATAP = this.chxDisableISATAP.Checked;
            this.DisplayNewDisabledComponentValue();
        }

        private void chxDisableTeredo_CheckedChanged(object sender, System.EventArgs e)
        {
            this.disabledComponentValue.DisableTeredo = this.chxDisableTeredo.Checked;
            this.DisplayNewDisabledComponentValue();
        }

        private void chxDisableIPv6OnAllNotTunnels_CheckedChanged(object sender, System.EventArgs e)
        {
            this.disabledComponentValue.DisableIPv6OnAllNotTunnels = this.chxDisableIPv6OnAllNotTunnels.Checked;
            this.DisplayNewDisabledComponentValue();
        }

        private void chxPreferIPv4_CheckedChanged(object sender, System.EventArgs e)
        {
            this.disabledComponentValue.PreferIPv4 = this.chxPreferIPv4.Checked;
            this.DisplayNewDisabledComponentValue();
        }

        private void chxDisableAllIpHttps_CheckedChanged(object sender, System.EventArgs e)
        {
            this.disabledComponentValue.DisableAllIpHttps = this.chxDisableAllIpHttps.Checked;
            this.DisplayNewDisabledComponentValue();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to write the new DisabledComponents DWORD hexdec. value: " + this.lblDisabledComponentHEX.Text + " to Windows registery?\r\nA reboot is required for change to be applied.", 
                "Apply settings?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            if (this.disabledComponentValue.WriteRegisteryValue())
            {
                MessageBox.Show("Writing settings succesfull.\r\nA reboot is required to apply new settings.", "Settings saved successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot open registery key need administrator privilege.", "No administrator privilege", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetCheckboxesByDisabledComponentValue()
        {
            this.chxDisable6to4.Checked = this.disabledComponentValue.Disable6to4;
            this.chxDisableAllIpHttps.Checked = this.disabledComponentValue.DisableAllIpHttps;
            this.chxDisableAllTransitionTechnologies.Checked = this.disabledComponentValue.DisableAllTransitionTechnologies;
            this.chxDisableIPv6OnAllNotTunnels.Checked = this.disabledComponentValue.DisableIPv6OnAllNotTunnels;
            this.chxDisableISATAP.Checked = this.disabledComponentValue.DisableISATAP;
            this.chxDisableTeredo.Checked = this.disabledComponentValue.DisableTeredo;
            this.chxPreferIPv4.Checked = this.disabledComponentValue.PreferIPv4;
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
