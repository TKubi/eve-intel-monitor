using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Windows.Forms;
using System.Net;

namespace EVEIntelManager
{
    public class ApplicationInstaller
    {

        public static AppVersion GetCurrentVersion()
        {
            Assembly appAssembly = Assembly.GetExecutingAssembly();
            Version version = GetVersion(appAssembly);

            AppVersion appVersion = new AppVersion();
            appVersion.Configuration = GetConfiguration(appAssembly);
            appVersion.SetVersion(version);

            return appVersion;
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

        public static void CheckForUpdates(IWin32Window parent) {
            try
            {
                AppVersionList versionList = DownloadVersions();

                AppVersion currentVersion = GetCurrentVersion();
                
                if (UpdateAvailable(versionList, currentVersion))
                {
                    ApplicationInstallerForm installerForm = new ApplicationInstallerForm();
                    installerForm.CurrentVersion = currentVersion;
                    installerForm.VersionList = versionList;

                    installerForm.LoadForm();

                    installerForm.Show(parent);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to check for update: " + e.Message);
            }
        }

        private static bool UpdateAvailable(AppVersionList list, AppVersion currentVersion)
        {
            if (list != null && list.Latest != null)
            {
                if (currentVersion.GetVersion() < list.Latest.GetVersion())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// http://developer.yahoo.com/dotnet/howto-xml_cs.html
        /// </summary>
        public static AppVersionList DownloadVersions()
        {
            string url = Properties.Settings.Default.UpdateVersionPath;

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(AppVersionList));

            AppVersionList list;
            using (XmlTextReader reader = new XmlTextReader(url))
            {
                object obj = serializer.Deserialize(reader);
                list = obj as AppVersionList;
            }

            return list;
        }
    }

    public class AppVersionList
    {
        public AppVersion[] Versions { get; set; }
        public AppVersion Latest { get; set; }

        public AppVersionList()
        {
            Versions = new AppVersion[] { };
        }
    }

    public class AppVersion
    {
        public string Configuration { get; set; }
        public string Version
        {
            get { 
                return version.ToString(); 
            }
            set
            { 
                this.version = new System.Version(value);
            }
        }
        
        public string URL { get; set; }
        public string Description { get; set; }
        public bool Released { get; set; }
        public long Size { get; set; }

        public Version GetVersion() {
            return version;
        }

        public void SetVersion(Version version)
        {
            this.version = version;
        }

        public AppVersion() { }
        public AppVersion(string configuration, string version, string url, bool released)
        {
            this.Configuration = configuration;
            this.Version = version;
            this.URL = url;
            this.Released = released;
        }

        public override string ToString()
        {
            if (Configuration == "")
            {
                Configuration = "";
            }

            if (Version != null)
            {
                return Configuration + " " + version.Major + "." + version.Minor;
            }
            else
            {
                return Configuration + " Unknown";
            }
        } 

        private Version version;
    }
}
