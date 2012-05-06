namespace Windows.UI.Xaml.Printing
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.Graphics.Printing;

    [ExclusiveTo(typeof(PaginateEventArgs)), Guid(0xed945fd6, 0x79ab, 0x42b7, 0x93, 10, 0x3d, 110, 9, 1, 0x1d, 0x21), Version(0x6020000), WebHostHidden]
    internal interface IPaginateEventArgs
    {
        int CurrentPreviewPageNumber { get; }

        Windows.Graphics.Printing.PrintTaskOptions PrintTaskOptions { get; }
    }
}

