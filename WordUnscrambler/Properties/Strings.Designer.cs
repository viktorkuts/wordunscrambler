﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WordUnscrambler.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WordUnscrambler.Properties.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to continue? Y/N.
        /// </summary>
        internal static string ContinuteInputPrompt {
            get {
                return ResourceManager.GetString("ContinuteInputPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Match found word .
        /// </summary>
        internal static string FoundMatch {
            get {
                return ResourceManager.GetString("FoundMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  with word .
        /// </summary>
        internal static string FoundMatchWith {
            get {
                return ResourceManager.GetString("FoundMatchWith", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter scrambled word(s) manually or as a file: F - file / M - manual.
        /// </summary>
        internal static string InitInputPrompt {
            get {
                return ResourceManager.GetString("InitInputPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File does not exist...
        /// </summary>
        internal static string InvalidFilePathInputPrompt {
            get {
                return ResourceManager.GetString("InvalidFilePathInputPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid input. Please enter Y to continue or N to exit..
        /// </summary>
        internal static string InvalidInputPrompt {
            get {
                return ResourceManager.GetString("InvalidInputPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select Language: 1 - English, 2 - Francais.
        /// </summary>
        internal static string LanguageInputPrompt {
            get {
                return ResourceManager.GetString("LanguageInputPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter word(s) manually (separated by commas if multiple):.
        /// </summary>
        internal static string ManualInputPrompt {
            get {
                return ResourceManager.GetString("ManualInputPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String is empty.
        /// </summary>
        internal static string NullString {
            get {
                return ResourceManager.GetString("NullString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter full path including the file name:.
        /// </summary>
        internal static string PathInputPrompt {
            get {
                return ResourceManager.GetString("PathInputPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The program will be terminated..
        /// </summary>
        internal static string Terminate {
            get {
                return ResourceManager.GetString("Terminate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The entered option was not recognized. Please enter F for file or M for manual entry..
        /// </summary>
        internal static string UnrecognizedInputPrompt {
            get {
                return ResourceManager.GetString("UnrecognizedInputPrompt", resourceCulture);
            }
        }
    }
}
