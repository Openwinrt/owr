namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x51ed9d7e, 0x2b53, 0x475b, 0x9c, 0x88, 12, 0x18, 50, 200, 0x35, 0x1a), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(DataTemplate))]
    internal interface IDataTemplateFactory
    {
        DataTemplate CreateInstance([In] object outer, out object inner);
    }
}

