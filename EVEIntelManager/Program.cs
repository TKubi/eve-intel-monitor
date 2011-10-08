using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using EVELogMonitor;
using System.IO;
using System.Xml;

namespace EVEIntelManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            LogDirectoryMonitor monitor = new LogDirectoryMonitor();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.FirstLoad)
            {
                Properties.Settings.Default.Upgrade();
            }

            IntelWindow window = new IntelWindow();

            window.Text = GetTitle();

            monitor.Path = GetEVELogDirectory();
            window.Monitor = monitor;

            Application.Run(window);

        }

        private static string GetEVELogDirectory()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.EVELogDirectory))
            {
                String myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Properties.Settings.Default.EVELogDirectory = myDocumentsFolder + @"\EVE\logs\Chatlogs\";
            }

            return Properties.Settings.Default.EVELogDirectory;
        }

        private static string GetTitle()
        {
            Assembly appAssembly = Assembly.GetExecutingAssembly();

            AppVersion appVersion = new AppVersion();
            appVersion.Configuration = GetConfiguration(appAssembly);
            appVersion.SetVersion(GetVersion(appAssembly));
            
            return "EVE Intel Monitor - " + appVersion;
        }

        private static string GetConfiguration(Assembly appAssembly)
        {
            Type type = typeof(AssemblyConfigurationAttribute);
            AssemblyConfigurationAttribute conf = AssemblyConfigurationAttribute.GetCustomAttribute(appAssembly, type)
                as AssemblyConfigurationAttribute;

            if (conf != null)
            {
                return conf.Configuration;
            }
            else
            {
                return "";
            }
        }

        private static Version GetVersion(Assembly appAssembly)
        {
            return appAssembly.GetName().Version;
        }
    }
}
