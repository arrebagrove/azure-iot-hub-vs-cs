﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AzureIoTHubConnectedService {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AzureIoTHubConnectedService.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Create New Account.
        /// </summary>
        internal static string CreateServiceInstanceText {
            get {
                return ResourceManager.GetString("CreateServiceInstanceText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select an existing account or create a new one by clicking the link below..
        /// </summary>
        internal static string GridHeaderText {
            get {
                return ResourceManager.GetString("GridHeaderText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Communicate between your devices and Azure IoT Hub..
        /// </summary>
        internal static string IoTHubProvdierDescription {
            get {
                return ResourceManager.GetString("IoTHubProvdierDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No storage accounts were found.  Choose another user or create a new storage No accounts were found.  Choose another user or create a new account to continue..
        /// </summary>
        internal static string NoServiceInstancesText {
            get {
                return ResourceManager.GetString("NoServiceInstancesText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to blah_ServiceInstanceNameLabelText.
        /// </summary>
        internal static string ServiceInstanceNameLabelText {
            get {
                return ResourceManager.GetString("ServiceInstanceNameLabelText", resourceCulture);
            }
        }
    }
}