﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dynamo.Nodes.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dynamo.Nodes.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manages connection to an Arduino microcontroller..
        /// </summary>
        public static string ArduinoDescription {
            get {
                return ResourceManager.GetString("ArduinoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Execution Interval.
        /// </summary>
        public static string ArduinoPortDataExecToolTip {
            get {
                return ResourceManager.GetString("ArduinoPortDataExecToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Serial port for later read/write.
        /// </summary>
        public static string ArduinoPortDataOutputToolTip {
            get {
                return ResourceManager.GetString("ArduinoPortDataOutputToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Serial output line.
        /// </summary>
        public static string ArduinoReadPortDataOutputToolTip {
            get {
                return ResourceManager.GetString("ArduinoReadPortDataOutputToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Whether or not the operation was successful..
        /// </summary>
        public static string ArduinoWritePortDataOutputToolTip {
            get {
                return ResourceManager.GetString("ArduinoWritePortDataOutputToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The delimeter in your data coming from the Arduino..
        /// </summary>
        public static string ArduionReadPortDataDelimiterToolTip {
            get {
                return ResourceManager.GetString("ArduionReadPortDataDelimiterToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text to be written.
        /// </summary>
        public static string ArduionWritePortDataTextToolTip {
            get {
                return ResourceManager.GetString("ArduionWritePortDataTextToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arduino serial connection.
        /// </summary>
        public static string PortDataArduinoToolTip {
            get {
                return ResourceManager.GetString("PortDataArduinoToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reads values from an Arduino microcontroller..
        /// </summary>
        public static string ReadArduinoDescription {
            get {
                return ResourceManager.GetString("ReadArduinoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Writes values to an Arduino microcontroller..
        /// </summary>
        public static string WriteArduinoDescription {
            get {
                return ResourceManager.GetString("WriteArduinoDescription", resourceCulture);
            }
        }
    }
}