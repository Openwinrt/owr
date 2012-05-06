namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media.Animation;

    [ExclusiveTo(typeof(ContentControl)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa26dd1dc, 0xcd44, 0x435c, 190, 0x94, 1, 0xd6, 0x24, 0x1c, 0x23, 0x1c), WebHostHidden]
    internal interface IContentControl
    {
        object Content { get; [param: In] set; }

        DataTemplate ContentTemplate { get; [param: In] set; }

        DataTemplateSelector ContentTemplateSelector { get; [param: In] set; }

        TransitionCollection ContentTransitions { get; [param: In] set; }
    }
}

