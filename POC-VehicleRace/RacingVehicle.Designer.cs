//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POC_VehicleRace {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class RacingVehicle {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RacingVehicle() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("POC_VehicleRace.RacingVehicle", typeof(RacingVehicle).Assembly);
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
        ///   Looks up a localized string similar to There is Some Error!! Please try again!!.
        /// </summary>
        internal static string GenericError {
            get {
                return ResourceManager.GetString("GenericError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ~/Content/images/.
        /// </summary>
        internal static string ImageLocation {
            get {
                return ResourceManager.GetString("ImageLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vehilce failed inspection..
        /// </summary>
        internal static string InspectionFailMessage {
            get {
                return ResourceManager.GetString("InspectionFailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Race track is already overloaded. In Order to add new please remove any vehicle from track first..
        /// </summary>
        internal static string OverloadMessage {
            get {
                return ResourceManager.GetString("OverloadMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vehicle Added on track..
        /// </summary>
        internal static string SuccessMessage {
            get {
                return ResourceManager.GetString("SuccessMessage", resourceCulture);
            }
        }
    }
}
