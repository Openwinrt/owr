namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Documents;

    [Version(0x6020000), ExclusiveTo(typeof(RichTextBlockOverflow)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x4f93749b, 0xdac3, 0x4a42, 0x9c, 0xbb, 0x99, 240, 0xde, 0x37, 0xc0, 0x71)]
    internal interface IRichTextBlockOverflow
    {
        bool Focus([In] FocusState value);
        TextPointer GetPositionFromPoint([In] Point point);

        double BaselineOffset { get; }

        TextPointer ContentEnd { get; }

        RichTextBlock ContentSource { get; }

        TextPointer ContentStart { get; }

        bool HasOverflowContent { get; }

        RichTextBlockOverflow OverflowContentTarget { get; [param: In] set; }

        Thickness Padding { get; [param: In] set; }
    }
}

