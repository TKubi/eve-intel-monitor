﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EVEIntelManager.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string EVELogDirectory {
            get {
                return ((string)(this["EVELogDirectory"]));
            }
            set {
                this["EVELogDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int ReadLogsAferSeconds {
            get {
                return ((int)(this["ReadLogsAferSeconds"]));
            }
            set {
                this["ReadLogsAferSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int LogRefreshRate {
            get {
                return ((int)(this["LogRefreshRate"]));
            }
            set {
                this["LogRefreshRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool AutoLoadDefaultChannel {
            get {
                return ((bool)(this["AutoLoadDefaultChannel"]));
            }
            set {
                this["AutoLoadDefaultChannel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool SettingsTabLast {
            get {
                return ((bool)(this["SettingsTabLast"]));
            }
            set {
                this["SettingsTabLast"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool FirstLoad {
            get {
                return ((bool)(this["FirstLoad"]));
            }
            set {
                this["FirstLoad"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool PlayIntelSound {
            get {
                return ((bool)(this["PlayIntelSound"]));
            }
            set {
                this["PlayIntelSound"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool TextToSpeech {
            get {
                return ((bool)(this["TextToSpeech"]));
            }
            set {
                this["TextToSpeech"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int TextToSpeechRate {
            get {
                return ((int)(this["TextToSpeechRate"]));
            }
            set {
                this["TextToSpeechRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string TextToSpeechVoice {
            get {
                return ((string)(this["TextToSpeechVoice"]));
            }
            set {
                this["TextToSpeechVoice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int TextToSpeechMaxMessages {
            get {
                return ((int)(this["TextToSpeechMaxMessages"]));
            }
            set {
                this["TextToSpeechMaxMessages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string DefaultChannel {
            get {
                return ((string)(this["DefaultChannel"]));
            }
            set {
                this["DefaultChannel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string StartupChannels {
            get {
                return ((string)(this["StartupChannels"]));
            }
            set {
                this["StartupChannels"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.ArrayList KeywordArrayList {
            get {
                return ((global::System.Collections.ArrayList)(this["KeywordArrayList"]));
            }
            set {
                this["KeywordArrayList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgrateOnStartup {
            get {
                return ((bool)(this["UpgrateOnStartup"]));
            }
            set {
                this["UpgrateOnStartup"] = value;
            }
        }
    }
}
