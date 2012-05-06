namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Text;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Media.Animation;

    [ExclusiveTo(typeof(ContentPresenter)), Windows.Foundation.Metadata.Guid(0x79fde5b4, 0xcd37, 0x491c, 0x88, 0x45, 0xda, 0xf4, 0x72, 0xde, 0xff, 0xf6), WebHostHidden, Version(0x6020000)]
    internal interface IContentPresenter
    {
        int CharacterSpacing { get; [param: In] set; }

        object Content { get; [param: In] set; }

        DataTemplate ContentTemplate { get; [param: In] set; }

        DataTemplateSelector ContentTemplateSelector { get; [param: In] set; }

        TransitionCollection ContentTransitions { get; [param: In] set; }

        Windows.UI.Xaml.Media.FontFamily FontFamily { get; [param: In] set; }

        double FontSize { get; [param: In] set; }

        Windows.UI.Text.FontStretch FontStretch { get; [param: In] set; }

        Windows.UI.Text.FontStyle FontStyle { get; [param: In] set; }

        Windows.UI.Text.FontWeight FontWeight { get; [param: In] set; }

        Brush Foreground { get; [param: In] set; }
    }
}

