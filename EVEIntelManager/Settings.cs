using System.Collections;
using System.Collections.Specialized;
namespace EVEIntelManager.Properties {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings {
        
        public Settings() {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }

        public string[] Keywords
        {
            get
            {
                if (this.KeywordArrayList != null)
                {
                    string[] keywords = new string[this.KeywordArrayList.Count];
                    this.KeywordArrayList.CopyTo(keywords, 0);
                    return keywords;
                }
                else
                {
                    return new string[] {};
                }
            }
            set
            {
                if (this.KeywordArrayList == null)
                {
                    this.KeywordArrayList = new StringCollection();
                }
                else
                {
                    this.KeywordArrayList.Clear();
                }
                this.KeywordArrayList.AddRange(value);
            }
        }
        
        public string[] StartupChannels
        {
            get
            {
                if (this.StartupChannelList != null)
                {
                    string[] keywords = new string[this.StartupChannelList.Count];
                    this.StartupChannelList.CopyTo(keywords, 0);
                    return keywords;
                }
                else
                {
                    return new string[] {};
                }
            }
            set
            {
                if (this.StartupChannelList == null)
                {
                    this.StartupChannelList = new StringCollection();
                }
                else
                {
                    this.StartupChannelList.Clear();
                }
                this.StartupChannelList.AddRange(value);
            }
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Add code to handle the SettingChangingEvent event here.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Add code to handle the SettingsSaving event here.
        }
    }
}
