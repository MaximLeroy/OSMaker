﻿// ------------------------------------------------------------------------------
// <auto-generated>
// Ce code a été généré par un outil.
// Version du runtime :4.0.30319.42000
// 
// Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
// le code est régénéré.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker.My
{
    [System.Runtime.CompilerServices.CompilerGenerated()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    internal sealed partial class MySettings : System.Configuration.ApplicationSettingsBase
    {
        private static MySettings defaultInstance = (MySettings)Synchronized(new MySettings());

        /* TODO ERROR: Skipped RegionDirectiveTrivia *//* TODO ERROR: Skipped IfDirectiveTrivia */
        private static bool addedHandler;
        private static object addedHandlerLockObject = new object();

        [DebuggerNonUserCode()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (MyProject.Application.SaveMySettingsOnExit)
            {
                MySettingsProperty.Settings.Save();
            }
        }
        /* TODO ERROR: Skipped EndIfDirectiveTrivia *//* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        public static MySettings Default
        {
            get
            {

                /* TODO ERROR: Skipped IfDirectiveTrivia */
                if (!addedHandler)
                {
                    lock (addedHandlerLockObject)
                    {
                        if (!addedHandler)
                        {
                            MyProject.Application.Shutdown += AutoSaveSettings;
                            addedHandler = true;
                        }
                    }
                }
                /* TODO ERROR: Skipped EndIfDirectiveTrivia */
                return defaultInstance;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool Ouvrir_Page_De_Démarrage
        {
            get
            {
                return Conversions.ToBoolean(this["Ouvrir_Page_De_Démarrage"]);
            }

            set
            {
                this["Ouvrir_Page_De_Démarrage"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool Autoriser_Envoyer_Informations
        {
            get
            {
                return Conversions.ToBoolean(this["Autoriser_Envoyer_Informations"]);
            }

            set
            {
                this["Autoriser_Envoyer_Informations"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("True")]
        public string Ecran_Demarrage
        {
            get
            {
                return Conversions.ToString(this["Ecran_Demarrage"]);
            }

            set
            {
                this["Ecran_Demarrage"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("")]
        public string Emplacement_Project_Par_Defaut
        {
            get
            {
                return Conversions.ToString(this["Emplacement_Project_Par_Defaut"]);
            }

            set
            {
                this["Emplacement_Project_Par_Defaut"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        public System.Collections.Specialized.StringCollection Projets_Recents
        {
            get
            {
                return (System.Collections.Specialized.StringCollection)this["Projets_Recents"];
            }

            set
            {
                this["Projets_Recents"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("")]
        public string Société
        {
            get
            {
                return Conversions.ToString(this["Société"]);
            }

            set
            {
                this["Société"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool Réduire_Panneau_Lateral_WindowsDesigner
        {
            get
            {
                return Conversions.ToBoolean(this["Réduire_Panneau_Lateral_WindowsDesigner"]);
            }

            set
            {
                this["Réduire_Panneau_Lateral_WindowsDesigner"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool Suivre_Souris_Regle
        {
            get
            {
                return Conversions.ToBoolean(this["Suivre_Souris_Regle"]);
            }

            set
            {
                this["Suivre_Souris_Regle"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool Afficher_La_Griller
        {
            get
            {
                return Conversions.ToBoolean(this["Afficher_La_Griller"]);
            }

            set
            {
                this["Afficher_La_Griller"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool Smart_Tags
        {
            get
            {
                return Conversions.ToBoolean(this["Smart_Tags"]);
            }

            set
            {
                this["Smart_Tags"] = value;
            }
        }

        [System.Configuration.UserScopedSetting()]
        [DebuggerNonUserCode()]
        [System.Configuration.DefaultSettingValue("False")]
        public bool Aimentation_Intelligente
        {
            get
            {
                return Conversions.ToBoolean(this["Aimentation_Intelligente"]);
            }

            set
            {
                this["Aimentation_Intelligente"] = value;
            }
        }
    }
}

namespace OSMaker.My
{
    [HideModuleName()]
    [DebuggerNonUserCode()]
    [System.Runtime.CompilerServices.CompilerGenerated()]
    internal static class MySettingsProperty
    {
        [System.ComponentModel.Design.HelpKeyword("My.Settings")]
        internal static MySettings Settings
        {
            get
            {
                return MySettings.Default;
            }
        }
    }
}