using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Net;
using System.Media;
using System.Deployment.Application;

namespace EVEIntelManager
{
    public class ApplicationInstaller
    {
        public delegate AppVersion GetSelectedVersionDelegate();
        public delegate void SetToolTipDelegate(string toolTip);
        public delegate void SetProgressDelegate(int value);

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

        public static bool CheckForUpdates(out AppVersionList versionList) {
            try
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    ApplicationDeployment deployment = ApplicationDeployment.CurrentDeployment;
                    
                    UpdateCheckInfo info = deployment.CheckForDetailedUpdate();

                    versionList = new AppVersionList();
                    
                    if (info.UpdateAvailable) {
                        versionList.Latest = new AppVersion(null, info.AvailableVersion, null, true);
                        versionList.Versions = new AppVersion[] { versionList.Latest };
                    }
                    
                    return info.UpdateAvailable;
                }
                else
                {
                    versionList = DownloadVersions();

                    if (UpdateAvailable(versionList))
                    {
                        return true;
                    }
                }
            }
            catch (DeploymentDownloadException dde)
            {
                SystemSounds.Beep.Play();
                Console.WriteLine("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: " + dde.Message);
                versionList = null;
            }
            catch (InvalidDeploymentException ide)
            {
                SystemSounds.Beep.Play();
                Console.WriteLine("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                versionList = null;
            }
            catch (InvalidOperationException ioe)
            {
                SystemSounds.Beep.Play();
                Console.WriteLine("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                versionList = null;
            }
            catch (Exception e)
            {
                SystemSounds.Beep.Play();
                Console.WriteLine("Unable to check for update: " + e.Message);

                versionList = null;
            }

            return false;
        }

        public static bool PromptUpgrade(out AppVersionList versionList)
        {
            try
            {
                versionList = DownloadVersions();
                return true;
            }
            catch (Exception e)
            {
                SystemSounds.Beep.Play();
                Console.WriteLine("Unable to check for update: " + e.Message);

                versionList = null;
            }

            return false;
        }

        private static bool UpdateAvailable(AppVersionList list)
        {
            AppVersion currentVersion = GetCurrentVersion();

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

        public static bool DownloadVersion(string URL, string outputPath, 
            SetToolTipDelegate SetToolTip, 
            SetProgressDelegate SetProgressMax,
            SetProgressDelegate AddProgressValue)
        {
            try
            {
                SetToolTip("Downloading " + URL);

                WebRequest objRequest = System.Net.HttpWebRequest.Create(URL);
                WebResponse objResponse = objRequest.GetResponse();

                SetProgressMax((int)objResponse.ContentLength);

                using (BinaryReader inputReader = new BinaryReader(objResponse.GetResponseStream()))
                {
                    using (FileStream outputStream = new FileStream(outputPath, FileMode.CreateNew))
                    {

                        byte[] buffer = new byte[32768];
                        int read;
                        while ((read = inputReader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            AddProgressValue(read);
                            outputStream.Write(buffer, 0, read);
                        }
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                SetToolTip("Unable to download " + URL + ": " + e.Message);
                SystemSounds.Beep.Play();

                return false;
            }
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

        public AppVersion(string configuration, Version version, string url, bool released)
        {
            this.Configuration = configuration;
            this.version = version;
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
