using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace IPv6Control
{
    class DisabledComponentValue
    {
        private int decvalue = 0;
        private bool disableAllTransitionTechnologies = false;
        private bool disable6to4 = false;
        private bool disableISATAP = false;
        private bool disableTeredo = false;
        private bool disableIPv6OnAllNotTunnels = false;
        private bool preferIPv4 = false;
        private bool disableAllIpHttps = false;

        public bool DisableAllTransitionTechnologies
        {
            get
            {
                return this.disableAllTransitionTechnologies;
            }
            set
            {
                if (value)
                {
                    this.decvalue += 1;
                } else
                {
                    this.decvalue -= 1;
                }

                this.disableAllTransitionTechnologies = value;
            }
        }

        public bool Disable6to4
        {
            get
            {
                return this.disable6to4;
            }
            set
            {
                if (value)
                {
                    this.decvalue += 2;
                } else
                {
                    this.decvalue -= 2;
                }
                
                this.disable6to4 = value;
            }
        }

        public bool DisableISATAP
        {
            get
            {
                return this.disableISATAP;
            }
            set
            {
                if (value)
                {
                    this.decvalue += 4;
                }
                else
                {
                    this.decvalue -= 4;
                }

                this.disableISATAP = value;
            }
        }

        public bool DisableTeredo
        {
            get
            {
                return this.disableTeredo;
            }
            set
            {
                if (value)
                {
                    this.decvalue += 8;
                }
                else
                {
                    this.decvalue -= 8;
                }

                this.disableTeredo = value;
            }
        }

        public bool DisableIPv6OnAllNotTunnels
        {
            get
            {
                return this.disableIPv6OnAllNotTunnels;
            }
            set
            {
                if (value)
                {
                    this.decvalue += 16;
                }
                else
                {
                    this.decvalue -= 16;
                }

                this.disableIPv6OnAllNotTunnels = value;
            }
        }

        public bool PreferIPv4
        {
            get
            {
                return this.preferIPv4;
            }
            set
            {
                if (value)
                {
                    this.decvalue += 32;
                }
                else
                {
                    this.decvalue -= 32;
                }

                this.preferIPv4 = value;
            }
        }

        public bool DisableAllIpHttps
        {
            get
            {
                return this.disableAllIpHttps;
            }
            set
            {
                if (value)
                {
                    this.decvalue += 128;
                }
                else
                {
                    this.decvalue -= 128;
                }

                this.disableAllIpHttps = value;
            }
        }

        public int GetDecValue()
        {
            return this.decvalue;
        }

        public string GetHexdecValueStr()
        {
            string hexdec = this.decvalue.ToString("X");
            if (hexdec.Length < 2)
            {
                hexdec = "0" + hexdec;
            }

            hexdec = "0x" + hexdec;
            return hexdec;
        }

        public bool WriteRegisteryValue()
        {
            Microsoft.Win32.RegistryKey keyip6param;
            try
            {
                keyip6param = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip6\\Parameters", true);
            }
            catch (SecurityException)
            {
                return false;
            }

            if (keyip6param == null)
            {
                return false;
            }

            bool writesucceeded = true;
            try
            {
                //keyip6param.GetValue()
                keyip6param.SetValue("DisabledComponents", this.decvalue, Microsoft.Win32.RegistryValueKind.DWord);
            }
            catch (UnauthorizedAccessException)
            {
                writesucceeded = false;
                //MessageBox.Show("No rights to edit registery key value", "No rights", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                keyip6param.Close();
            }

            return writesucceeded;
        }
    }
}
