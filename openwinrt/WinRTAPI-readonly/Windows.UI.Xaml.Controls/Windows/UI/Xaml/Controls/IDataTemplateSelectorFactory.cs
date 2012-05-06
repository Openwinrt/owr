namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x511baad0, 0x210a, 0x457d, 0x95, 0x21, 0x43, 0x3d, 0x2b, 0x11, 0xb7, 210), ExclusiveTo(typeof(DataTemplateSelector)), WebHostHidden]
    internal interface IDataTemplateSelectorFactory
    {
        DataTemplateSelector CreateInstance([In] object outer, out object inner);
    }
}

