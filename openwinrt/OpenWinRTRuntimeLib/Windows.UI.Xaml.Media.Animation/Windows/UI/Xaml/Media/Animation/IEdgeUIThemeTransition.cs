namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Windows.Foundation.Metadata.Guid(0x5c86c19b, 0x49d7, 0x19ec, 0xcf, 0x19, 0x83, 0xa7, 60, 0x6d, 0xe7, 0x5e), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(EdgeUIThemeTransition))]
    internal interface IEdgeUIThemeTransition
    {
        EdgeTransitionLocation Edge { get; [param: In] set; }
    }
}

