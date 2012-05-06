namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Text;
    using Windows.UI.Xaml.Media;

    [Windows.Foundation.Metadata.Guid(0xe83b0062, 0xd776, 0x4f92, 0xba, 0xea, 0x40, 0xe7, 0x7d, 0x47, 0x91, 0xd5), ExclusiveTo(typeof(TextElement)), Version(0x6020000), WebHostHidden]
    internal interface ITextElement
    {
        object FindName([In] string name);

        int CharacterSpacing { get; [param: In] set; }

        TextPointer ContentEnd { get; }

        TextPointer ContentStart { get; }

        TextPointer ElementEnd { get; }

        TextPointer ElementStart { get; }

        Windows.UI.Xaml.Media.FontFamily FontFamily { get; [param: In] set; }

        double FontSize { get; [param: In] set; }

        Windows.UI.Text.FontStretch FontStretch { get; [param: In] set; }

        Windows.UI.Text.FontStyle FontStyle { get; [param: In] set; }

        Windows.UI.Text.FontWeight FontWeight { get; [param: In] set; }

        Brush Foreground { get; [param: In] set; }

        string Language { get; [param: In] set; }

        string Name { get; }
    }
}

