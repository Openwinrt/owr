namespace Windows.UI.Xaml.Shapes
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x46a5433d, 0x4ffb, 0x48df, 0x87, 50, 0x4e, 0x15, 200, 0x34, 0x81, 0x6b), WebHostHidden, ExclusiveTo(typeof(Line)), Version(0x6020000)]
    internal interface ILine
    {
        double X1 { get; [param: In] set; }

        double X2 { get; [param: In] set; }

        double Y1 { get; [param: In] set; }

        double Y2 { get; [param: In] set; }
    }
}

