namespace Windows.UI.Xaml
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [ExclusiveTo(typeof(Style)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0xa36824e3, 0x3d81, 0x4ce5, 170, 0x51, 0x8b, 0x41, 15, 0x60, 0x2f, 0xcd)]
    internal interface IStyleFactory
    {
        Style CreateInstance([In] TypeName targetType);
    }
}

