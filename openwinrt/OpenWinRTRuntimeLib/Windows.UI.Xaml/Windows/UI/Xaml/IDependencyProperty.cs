namespace Windows.UI.Xaml
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Version(0x6020000), ExclusiveTo(typeof(DependencyProperty)), Windows.Foundation.Metadata.Guid(0x85b13970, 0x9bc4, 0x4e96, 0xac, 0xf1, 0x30, 200, 0xfd, 0x3d, 0x55, 200), WebHostHidden]
    internal interface IDependencyProperty
    {
        PropertyMetadata GetMetadata([In] TypeName forType);
    }
}

