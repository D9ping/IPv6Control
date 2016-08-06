using System;
using System.Security;

namespace IPv6Control
{
    class DisabledComponentValue
    {
        private UInt32 decvalue = 0;
        private bool docalculatevalue = false;

        private bool disableAllTransitionTechnologies = false;
        private bool disable6to4 = false;
        private bool disableISATAP = false;
        private bool disableTeredo = false;
        private bool disableIPv6OnAllNotTunnels = false;
        private bool preferIPv4 = false;
        private bool disableAllIpHttps = false;

        /// <summary>
        /// Creating a new instance of DisabledComponentValue class.
        /// </summary>
        public DisabledComponentValue()
        {
        }

        public bool DoCalculateValue
        {
            set
            {
                this.docalculatevalue = value;
            }
        }

        public bool DisableAllTransitionTechnologies
        {
            get
            {
                return this.disableAllTransitionTechnologies;
            }
            set
            {
                if (this.docalculatevalue)
                {
                    if (value)
                    {
                        this.decvalue += 1;
                    }
                    else
                    {
                        this.decvalue -= 1;
                    }
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
                if (this.docalculatevalue)
                {
                    if (value)
                    {
                        this.decvalue += 2;
                    }
                    else
                    {
                        this.decvalue -= 2;
                    }
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
                if (this.docalculatevalue)
                {
                    if (value)
                    {
                        this.decvalue += 4;
                    }
                    else
                    {
                        this.decvalue -= 4;
                    }
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
                if (this.docalculatevalue)
                {
                    if (value)
                    {
                        this.decvalue += 8;
                    }
                    else
                    {
                        this.decvalue -= 8;
                    }
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
                if (this.docalculatevalue)
                {
                    if (value)
                    {
                        this.decvalue += 16;
                    }
                    else
                    {
                        this.decvalue -= 16;
                    }
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
                if (this.docalculatevalue)
                {
                    if (value)
                    {
                        this.decvalue += 32;
                    }
                    else
                    {
                        this.decvalue -= 32;
                    }
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
                if (this.docalculatevalue)
                {
                    if (value)
                    {
                        this.decvalue += 128;
                    }
                    else
                    {
                        this.decvalue -= 128;
                    }
                }

                this.disableAllIpHttps = value;
            }
        }

        public UInt32 GetDecValue()
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

        /// <summary>
        /// Load the DisabledComponents registery value and set boolean properties of this class.
        /// Administrator rights are required to read the registery value.
        /// </summary>
        /// <returns>True if loading from registery succesfull.</returns>
        public bool LoadFromRegisteryValue()
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

            bool loadsucceeded = false;
            try
            {
                Object objDisabledComponents = keyip6param.GetValue("DisabledComponents");
                UInt32 newdecvalue;
                if (UInt32.TryParse(objDisabledComponents.ToString(), out newdecvalue))
                {
                    this.decvalue = newdecvalue;
                    if (newdecvalue - 128 <= 255)
                    {
                        newdecvalue -= 128;
                        this.DisableAllIpHttps = true;
                    }

                    if (newdecvalue - 32 <= 255)
                    {
                        newdecvalue -= 32;
                        this.preferIPv4 = true;
                    }

                    if (newdecvalue - 16 <= 255)
                    {
                        newdecvalue -= 16;
                        this.DisableIPv6OnAllNotTunnels = true;
                    }

                    if (newdecvalue - 8 <= 255)
                    {
                        newdecvalue -= 8;
                        this.DisableTeredo = true;
                    }

                    if (newdecvalue - 4 <= 255)
                    {
                        newdecvalue -= 4;
                        this.DisableISATAP = true;
                    }

                    if (newdecvalue - 2 <= 255)
                    {
                        newdecvalue -= 2;
                        this.Disable6to4 = true;
                    }

                    if (newdecvalue - 1 <= 255)
                    {
                        newdecvalue -= 1;
                        this.DisableAllTransitionTechnologies = true;
                    }

                    loadsucceeded = true;
                }
            } catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return loadsucceeded;
        }

        /// <summary>
        /// Write the DisabledComponents registery value.
        /// Needs administrator rights to write the registery value.
        /// </summary>
        /// <returns>True if writing to registery is succesfull (needs administrator rights to do this).</returns>
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
                keyip6param.SetValue("DisabledComponents", this.decvalue, Microsoft.Win32.RegistryValueKind.DWord);
            }
            catch (UnauthorizedAccessException)
            {
                writesucceeded = false;
            }
            finally
            {
                keyip6param.Close();
            }

            return writesucceeded;
        }
    }
}
