using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using EVELogMonitor;
using System.IO;
using System.Xml;
using System.Threading;
using System.Diagnostics;
using System.Text;
using System.Globalization;

namespace EVEIntelManager
{
    static class Program
    {
        private static bool s_showWindowOnError = true;

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


        #region Callbacks
        /// <summary>
        /// THIS code is borrowed from EVEmon
        /// 
        /// If <see cref="Application.Exit()"/> is called before the <see cref="Application.Run()"/> method, then it won't occur. 
        /// So, here, we set up a boolean to prevent that.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ApplicationExitCallback(object sender, EventArgs e)
        {
            // do nothing here for now
        }

        /// <summary>
        /// Occurs when an exception reach the entry point of the
        /// application. We then display our custom crash box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleUnhandledException(e.ExceptionObject as Exception);
        }

        /// <summary>
        /// Handles exceptions in WinForms threads, such exceptions
        /// would never reach the entry point of the application, 
        /// generally causing a CTD or trigger WER. We display our
        /// custom crash box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleUnhandledException(e.Exception as Exception);
        }

        /// <summary>
        /// Handles an exception through the Unhandled Exception window
        /// </summary>
        /// <param name="ex">Exception to display</param>
        private static void HandleUnhandledException(Exception ex)
        {
            if (!Debugger.IsAttached)
            {
                if (s_showWindowOnError)
                {
                    s_showWindowOnError = false;

                    // Shutdown EveClient timer incase that was causing the crash
                    // so we don't get multiple crashes
                    //try
                    //{
                        //using (UnhandledExceptionWindow f = new UnhandledExceptionWindow(ex))
                        //{
                        //    f.ShowDialog(s_mainWindow);
                        //}
                    //}
                    //catch
                    //{
                    StringBuilder MessageBuilder = new StringBuilder();
                    MessageBuilder.AppendLine("An error occurred and EVEMon was unable to handle the error message gracefully");
                    MessageBuilder.AppendLine();
                    MessageBuilder.AppendFormat(CultureInfo.CurrentCulture, "The exception encountered was '{0}'.", ex.Message);
                    MessageBuilder.AppendLine();
                    MessageBuilder.AppendLine();
                    MessageBuilder.AppendLine("Please report this on the EVEMon forums.");
                    MessageBox.Show(MessageBuilder.ToString(), "EVEMon Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}

                    Environment.Exit(1);
                }
            }
        }
        #endregion
    }

}
