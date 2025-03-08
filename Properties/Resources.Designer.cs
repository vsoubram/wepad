// This file is auto-generated. Do not modify it directly. 

namespace wepad.Properties {
    using System;
    using System.Drawing;
    using System.Resources;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Windows;

    [CompilerGenerated]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    internal class Resources {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("wepad.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture {
            get { return resourceCulture; }
            set { resourceCulture = value; }
        }

        internal static string SomeString {
            get {
                return ResourceManager.GetString("SomeString", resourceCulture);
            }
        }

        internal static Bitmap SomeImage {
            get {
                object obj = ResourceManager.GetObject("SomeImage", resourceCulture);
                return ((Bitmap)(obj));
            }
        }

        // Add more resource properties here as needed.
    }
}