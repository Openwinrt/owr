namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PathGeometry)), Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x81b9df8, 0xbae6, 0x4bcb, 0x81, 60, 0xbd, 0xe0, 0xe4, 0x6d, 200, 0xb7)]
    internal interface IPathGeometry
    {
        PathFigureCollection Figures { get; [param: In] set; }

        Windows.UI.Xaml.Media.FillRule FillRule { get; [param: In] set; }
    }
}

