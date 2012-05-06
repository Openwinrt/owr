namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x7c925755, 0x3e48, 0x42b4, 0x86, 0x77, 0x76, 0x37, 0x22, 0x67, 3, 0x3f)]
    public interface ICustomPropertyProvider
    {
        ICustomProperty GetCustomProperty([In] string name);
        ICustomProperty GetIndexedProperty([In] string name, [In] TypeName type);
        string GetStringRepresentation();

        TypeName Type { get; }
    }
}

