namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CurrentChangingEventArgs)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x153bbeee, 0x62f3, 0x48cf, 0x81, 0x83, 0x8b, 0xe2, 0x6d, 0xe3, 0xa6, 110)]
    internal interface ICurrentChangingEventArgsFactory
    {
        CurrentChangingEventArgs CreateInstance([In] object outer, out object inner);
        CurrentChangingEventArgs CreateWithCancelableParameter([In] bool isCancelable, [In] object outer, out object inner);
    }
}

