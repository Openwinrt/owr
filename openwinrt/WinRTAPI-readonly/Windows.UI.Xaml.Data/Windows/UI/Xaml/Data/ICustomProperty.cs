namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x30da92c0, 0x23e8, 0x42a0, 0xae, 0x7c, 0x73, 0x4a, 14, 0x5d, 0x27, 130)]
    public interface ICustomProperty
    {
        object GetIndexedValue([In] object target, [In] object index);
        object GetValue([In] object target);
        void SetIndexedValue([In] object target, [In] object value, [In] object index);
        void SetValue([In] object target, [In] object value);

        bool CanRead { get; }

        bool CanWrite { get; }

        string Name { get; }

        TypeName Type { get; }
    }
}

