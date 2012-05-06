namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(VisualStateManager)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x85e598fd, 0xa575, 0x47b6, 0x9e, 0x30, 0x38, 60, 0xd0, 0x85, 0x85, 0xf2)]
    internal interface IVisualStateManagerFactory
    {
        VisualStateManager CreateInstance([In] object outer, out object inner);
    }
}

