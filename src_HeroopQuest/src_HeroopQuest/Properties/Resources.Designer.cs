﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace src_HeroopQuest.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("src_HeroopQuest.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Je bent de Barbaar, de sterkste krijger van allemaal. Maar pas op voor toverkunsten want daar beschermt je zwaard je niet tegen..
        /// </summary>
        internal static string barbaarBeschrijving {
            get {
                return ResourceManager.GetString("barbaarBeschrijving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jij bent de Dwerg. Je bent een goed krijger en alleen jij kunt iedere val die je tegenkomt (zichtbaar in dezelfde gang of kamer) onschadelijk maken zonder daarvoor de uitrustingskaart *Gereedschapkist* te gebruiken..
        /// </summary>
        internal static string dwergBeschrijving {
            get {
                return ResourceManager.GetString("dwergBeschrijving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jij bent de Elf. Een meester in de magie en in het gevecht. Als je het kwaad wilt overwinnen zul je beide goed moeten gebruiken..
        /// </summary>
        internal static string elfBeschrijving {
            get {
                return ResourceManager.GetString("elfBeschrijving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jij bent de Tovenaar. Je kent vele toverspreuken die je kunnen helpen. In het gevecht van je echter minder sterk. Dus gebruik je tovenarij verstandig en vermijd de strijd..
        /// </summary>
        internal static string tovenaarBeschrijving {
            get {
                return ResourceManager.GetString("tovenaarBeschrijving", resourceCulture);
            }
        }
    }
}