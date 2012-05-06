namespace Windows.UI.Xaml.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(GetPreviewPageEventArgs)), WebHostHidden, Guid(0xa43d703d, 0xdea9, 0x4df6, 0xa7, 0xed, 0x35, 4, 0x9c, 0xd4, 0x85, 0xc7), Version(0x6020000)]
    internal interface IGetPreviewPageEventArgs
    {
        int PageNumber { get; }
    }
}

