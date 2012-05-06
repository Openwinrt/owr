namespace Windows.UI.Xaml.Controls
{
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(RichTextBlockOverflow)), Guid(0x41ac2f7, 0x4f2b, 0x43c3, 0xa1, 0x22, 0x3f, 0xea, 0x9c, 0xa9, 220, 0x87)]
    internal interface IRichTextBlockOverflowStatics
    {
        DependencyProperty HasOverflowContentProperty { get; }

        DependencyProperty OverflowContentTargetProperty { get; }

        DependencyProperty PaddingProperty { get; }
    }
}

