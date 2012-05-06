namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xae814041, 0xc531, 0x43b4, 0xbf, 0x99, 0x12, 0xf5, 6, 0xf7, 0xb0, 0x1c), ExclusiveTo(typeof(Grid)), WebHostHidden]
    internal interface IGridFactory
    {
        Grid CreateInstance([In] object outer, out object inner);
    }
}

