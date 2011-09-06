using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Windows.Forms;

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
            AppVersion latestVersion = DownloadVersions();
            if (latestVersion != null) {
                PromptWindow.Show(parent, "Update", "Update to " + latestVersion + "? (Yes/No)", "Yes", YesNoInputValidator);
            }
        }

        public static bool YesNoInputValidator(string input)
        {
            return !string.IsNullOrEmpty(input) &&
                (input.Trim().ToLower().Equals("yes") || input.Trim().ToLower().Equals("no"));
        }
        /// <summary>
        /// http://developer.yahoo.com/dotnet/howto-xml_cs.html
        /// </summary>
        public static AppVersion DownloadVersions()
        {
           // System.Threading.Thread.Sleep(5000);
            AppVersion currentVersion = GetCurrentVersion();

            string url = Properties.Settings.Default.UpdateVersionPath;

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(AppVersionList));

            AppVersionList list;
            using (XmlTextReader reader = new XmlTextReader(url))
            {
                object obj = serializer.Deserialize(reader);
                list = obj as AppVersionList;
            }

            if (list != null && list.Latest != null) 
            {
                if (currentVersion.GetVersion() < list.Latest.GetVersion())
                {
                    return list.Latest;
                }
                else
                {
                    return null;
                }
            } else {
                
                list = new AppVersionList();
                list.Versions = new AppVersion[] {
                    new AppVersion("Beta", "0.3", @"http://eve-intel-monitor.googlecode.com/files/EVE-Intel-Monitor.v0.3.msi", true),
                    new AppVersion("Beta", "0.4", @"http://eve-intel-monitor.googlecode.com/files/EVE-Intel-Monitor.v0.4.msi", true),
                    new AppVersion("Beta", "0.5", @"http://eve-intel-monitor.googlecode.com/files/EVE-Intel-Monitor.v0.5.msi", true)
                };
                list.Latest = list.Versions[list.Versions.Length - 1];

                using (FileStream stream = new FileStream(@"C:\Users\Simon\Documents\Visual Studio 2008\Projects\eve-intel-monitor\doc\versions4.xml",
                    FileMode.Create))
                {

                    serializer.Serialize(stream, list);
                }
            }
    
            return null;
            //serializer.Serialize(new FileStream(url, FileMode.Create), list);


/*            // Retrieve XML document  
            
            // Skip non-significant whitespace  
            reader.WhitespaceHandling = WhitespaceHandling.Significant;  
            
            // Read nodes one at a time  
            while (reader.Read())  
            {
                string configuration = "";

                if (reader.NodeType.ToString() == "version")
                {
                    reader.MoveToAttribute(1);
                    if (reader.Name == "configuration")
                    {
                    }
                }
                // Print out info on node  
                Console.WriteLine("{0}: {1}", reader.NodeType.ToString(), reader.Name);  
            }  */
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
