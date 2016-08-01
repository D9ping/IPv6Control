using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace IPv6Control
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new FrmMain());
        }

        /// <summary>
        /// Gets the application title.
        /// </summary>
        public static string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (!string.IsNullOrEmpty(titleAttribute.Title))
                    {
                        return titleAttribute.Title;
                    }
                }

                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// Gets the application version as string, without the .net revision number.
        /// <summary>
        /// <returns>A string containing the version number of this application in the form of major.minor.release/'dotNET build' number.</returns>
        public static string AssemblyVersion
        {
            get
            {
                StringBuilder sbversion = new StringBuilder(Assembly.GetExecutingAssembly().GetName().Version.Major.ToString());
                sbversion.Append(".");
                sbversion.Append(Assembly.GetExecutingAssembly().GetName().Version.Minor);
                sbversion.Append(".");
                sbversion.Append(Assembly.GetExecutingAssembly().GetName().Version.Build);
                return sbversion.ToString();
            }
        }
    }
}
