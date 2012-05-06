namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Media.Animation;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa50a4bbd, 0x8361, 0x469c, 0x90, 0xda, 0xe9, 0xa4, 12, 0x74, 0x74, 0xdf), WebHostHidden, ExclusiveTo(typeof(Panel))]
    internal interface IPanel
    {
        Brush Background { get; [param: In] set; }

        UIElementCollection Children { get; }

        TransitionCollection ChildrenTransitions { get; [param: In] set; }

        bool IsItemsHost { get; }
    }
}

