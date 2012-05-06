namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PathFigure)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x5d955c8c, 0x5fa9, 0x4dda, 0xa3, 0xcc, 0x10, 0xfc, 220, 170, 0x20, 0xd7)]
    internal interface IPathFigure
    {
        bool IsClosed { get; [param: In] set; }

        bool IsFilled { get; [param: In] set; }

        PathSegmentCollection Segments { get; [param: In] set; }

        Point StartPoint { get; [param: In] set; }
    }
}

