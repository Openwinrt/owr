namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(CurrentChangingEventArgs)), Windows.Foundation.Metadata.Guid(0xf9891e29, 0x51cc, 0x47dd, 0xa5, 0xb9, 0x35, 220, 0x49, 20, 0xaf, 0x69)]
    internal interface ICurrentChangingEventArgs
    {
        bool Cancel { get; [param: In] set; }

        bool IsCancelable { get; }
    }
}

