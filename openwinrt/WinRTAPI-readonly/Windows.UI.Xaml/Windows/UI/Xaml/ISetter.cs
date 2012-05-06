namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, ExclusiveTo(typeof(Setter)), Windows.Foundation.Metadata.Guid(0xa73ded29, 0xb4ae, 0x4a81, 190, 0x85, 230, 0x90, 0xba, 13, 0x3b, 110), Version(0x6020000)]
    internal interface ISetter
    {
        DependencyProperty Property { get; [param: In] set; }

        object Value { get; [param: In] set; }
    }
}

