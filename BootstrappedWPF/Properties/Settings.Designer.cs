﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BootstrappedWPF.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1050")]
        public int Width {
            get {
                return ((int)(this["Width"]));
            }
            set {
                this["Width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("660")]
        public int Height {
            get {
                return ((int)(this["Height"]));
            }
            set {
                this["Height"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>English</string>
  <string>Japanese</string>
  <string>French</string>
  <string>German</string>
  <string>Chinese</string>
  <string>Korean</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection GameLanguages {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["GameLanguages"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseLocalJSONCache {
            get {
                return ((bool)(this["UseLocalJSONCache"]));
            }
            set {
                this["UseLocalJSONCache"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("English")]
        public string InterfaceLanguage {
            get {
                return ((string)(this["InterfaceLanguage"]));
            }
            set {
                this["InterfaceLanguage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DarkMode {
            get {
                return ((bool)(this["DarkMode"]));
            }
            set {
                this["DarkMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("deeppurple")]
        public string UserThemePrimary {
            get {
                return ((string)(this["UserThemePrimary"]));
            }
            set {
                this["UserThemePrimary"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("purple")]
        public string UserThemeAccent {
            get {
                return ((string)(this["UserThemeAccent"]));
            }
            set {
                this["UserThemeAccent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public double ActionWorkerTiming {
            get {
                return ((double)(this["ActionWorkerTiming"]));
            }
            set {
                this["ActionWorkerTiming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250")]
        public double ActorWorkerTiming {
            get {
                return ((double)(this["ActorWorkerTiming"]));
            }
            set {
                this["ActorWorkerTiming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250")]
        public double ChatLogWorkerTiming {
            get {
                return ((double)(this["ChatLogWorkerTiming"]));
            }
            set {
                this["ChatLogWorkerTiming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public double CurrentPlayerWorkerTiming {
            get {
                return ((double)(this["CurrentPlayerWorkerTiming"]));
            }
            set {
                this["CurrentPlayerWorkerTiming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public double InventoryWorkerTiming {
            get {
                return ((double)(this["InventoryWorkerTiming"]));
            }
            set {
                this["InventoryWorkerTiming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250")]
        public double JobResourceWorkerTiming {
            get {
                return ((double)(this["JobResourceWorkerTiming"]));
            }
            set {
                this["JobResourceWorkerTiming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public double PartyWorkerTiming {
            get {
                return ((double)(this["PartyWorkerTiming"]));
            }
            set {
                this["PartyWorkerTiming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public double TargetWorkerTiming {
            get {
                return ((double)(this["TargetWorkerTiming"]));
            }
            set {
                this["TargetWorkerTiming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(Default)")]
        public global::System.Globalization.CultureInfo Culture {
            get {
                return ((global::System.Globalization.CultureInfo)(this["Culture"]));
            }
            set {
                this["Culture"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CultureSet {
            get {
                return ((bool)(this["CultureSet"]));
            }
            set {
                this["CultureSet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Left {
            get {
                return ((int)(this["Left"]));
            }
            set {
                this["Left"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Top {
            get {
                return ((int)(this["Top"]));
            }
            set {
                this["Top"] = value;
            }
        }
    }
}
