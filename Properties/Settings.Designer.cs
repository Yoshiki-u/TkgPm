﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeisanKanri.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TmPmDB.mdf;In" +
            "tegrated Security=True;Connect Timeout=30")]
        public string TmPmDBConnectionString {
            get {
                return ((string)(this["TmPmDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TmDB.mdf;Inte" +
            "grated Security=True;Connect Timeout=30")]
        public string TmDBConnectionString {
            get {
                return ((string)(this["TmDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\YOSHI\\SOURCE\\REPOS\\TA" +
            "KAGIMOKKOU\\TMDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;Tr" +
            "ustServerCertificate=False")]
        public string C__USERS_YOSHI_SOURCE_REPOS_TAKAGIMOKKOU_TMDB_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_YOSHI_SOURCE_REPOS_TAKAGIMOKKOU_TMDB_MDFConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("高木木工株式会社")]
        public string TkgName {
            get {
                return ((string)(this["TkgName"]));
            }
            set {
                this["TkgName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("〒444-0011 愛知県岡崎市欠町字下口2番地")]
        public string TkgAddress {
            get {
                return ((string)(this["TkgAddress"]));
            }
            set {
                this["TkgAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TEL 0564-21-0058  FAX 0564-21-5236")]
        public string TkgTelFax {
            get {
                return ((string)(this["TkgTelFax"]));
            }
            set {
                this["TkgTelFax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E-mail  takagi.m.k@way.ocn.ne.jp")]
        public string TkgEmail {
            get {
                return ((string)(this["TkgEmail"]));
            }
            set {
                this["TkgEmail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("株式会社 大井野木製作所")]
        public string OoinoName {
            get {
                return ((string)(this["OoinoName"]));
            }
            set {
                this["OoinoName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ConnectStr {
            get {
                return ((string)(this["ConnectStr"]));
            }
            set {
                this["ConnectStr"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProFName {
            get {
                return ((string)(this["ProFName"]));
            }
            set {
                this["ProFName"] = value;
            }
        }
    }
}