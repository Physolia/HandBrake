﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Handbrake.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool updateStatus {
            get {
                return ((bool)(this["updateStatus"]));
            }
            set {
                this["updateStatus"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool tooltipEnable {
            get {
                return ((bool)(this["tooltipEnable"]));
            }
            set {
                this["tooltipEnable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string defaultPreset {
            get {
                return ((string)(this["defaultPreset"]));
            }
            set {
                this["defaultPreset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int skipversion {
            get {
                return ((int)(this["skipversion"]));
            }
            set {
                this["skipversion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool autoNaming {
            get {
                return ((bool)(this["autoNaming"]));
            }
            set {
                this["autoNaming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string autoNamePath {
            get {
                return ((string)(this["autoNamePath"]));
            }
            set {
                this["autoNamePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://handbrake.fr/appcast.xml")]
        public string appcast {
            get {
                return ((string)(this["appcast"]));
            }
            set {
                this["appcast"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://handbrake.fr/appcast_unstable.xml")]
        public string appcast_unstable {
            get {
                return ((string)(this["appcast_unstable"]));
            }
            set {
                this["appcast_unstable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{source}-{title}")]
        public string autoNameFormat {
            get {
                return ((string)(this["autoNameFormat"]));
            }
            set {
                this["autoNameFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\VideoLAN\\vlc\\vlc.exe")]
        public string VLC_Path {
            get {
                return ((string)(this["VLC_Path"]));
            }
            set {
                this["VLC_Path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MainWindowMinimize {
            get {
                return ((bool)(this["MainWindowMinimize"]));
            }
            set {
                this["MainWindowMinimize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool QueryEditorTab {
            get {
                return ((bool)(this["QueryEditorTab"]));
            }
            set {
                this["QueryEditorTab"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool presetNotification {
            get {
                return ((bool)(this["presetNotification"]));
            }
            set {
                this["presetNotification"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool trayIconAlerts {
            get {
                return ((bool)(this["trayIconAlerts"]));
            }
            set {
                this["trayIconAlerts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime lastUpdateCheckDate {
            get {
                return ((global::System.DateTime)(this["lastUpdateCheckDate"]));
            }
            set {
                this["lastUpdateCheckDate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public int daysBetweenUpdateCheck {
            get {
                return ((int)(this["daysBetweenUpdateCheck"]));
            }
            set {
                this["daysBetweenUpdateCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int useM4v {
            get {
                return ((int)(this["useM4v"]));
            }
            set {
                this["useM4v"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PromptOnUnmatchingQueries {
            get {
                return ((bool)(this["PromptOnUnmatchingQueries"]));
            }
            set {
                this["PromptOnUnmatchingQueries"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Any")]
        public string NativeLanguage {
            get {
                return ((string)(this["NativeLanguage"]));
            }
            set {
                this["NativeLanguage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255")]
        public int DubMode {
            get {
                return ((int)(this["DubMode"]));
            }
            set {
                this["DubMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CliExeHash {
            get {
                return ((string)(this["CliExeHash"]));
            }
            set {
                this["CliExeHash"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int previewScanCount {
            get {
                return ((int)(this["previewScanCount"]));
            }
            set {
                this["previewScanCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool clearOldLogs {
            get {
                return ((bool)(this["clearOldLogs"]));
            }
            set {
                this["clearOldLogs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoNameTitleCase {
            get {
                return ((bool)(this["AutoNameTitleCase"]));
            }
            set {
                this["AutoNameTitleCase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoNameRemoveUnderscore {
            get {
                return ((bool)(this["AutoNameRemoveUnderscore"]));
            }
            set {
                this["AutoNameRemoveUnderscore"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpdateRequired {
            get {
                return ((bool)(this["UpdateRequired"]));
            }
            set {
                this["UpdateRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ActivityWindowLastMode {
            get {
                return ((int)(this["ActivityWindowLastMode"]));
            }
            set {
                this["ActivityWindowLastMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool useClosedCaption {
            get {
                return ((bool)(this["useClosedCaption"]));
            }
            set {
                this["useClosedCaption"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("35")]
        public int batchMinDuration {
            get {
                return ((int)(this["batchMinDuration"]));
            }
            set {
                this["batchMinDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("47")]
        public int batchMaxDuration {
            get {
                return ((int)(this["batchMaxDuration"]));
            }
            set {
                this["batchMaxDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool defaultPlayer {
            get {
                return ((bool)(this["defaultPlayer"]));
            }
            set {
                this["defaultPlayer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" />")]
        public global::System.Collections.Specialized.StringCollection SelectedLanguages {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SelectedLanguages"]));
            }
            set {
                this["SelectedLanguages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int DubModeAudio {
            get {
                return ((int)(this["DubModeAudio"]));
            }
            set {
                this["DubModeAudio"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DubModeSubtitle {
            get {
                return ((int)(this["DubModeSubtitle"]));
            }
            set {
                this["DubModeSubtitle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool addOnlyOneAudioPerLanguage {
            get {
                return ((bool)(this["addOnlyOneAudioPerLanguage"]));
            }
            set {
                this["addOnlyOneAudioPerLanguage"] = value;
            }
        }
    }
}
