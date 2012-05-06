namespace Windows.UI.Xaml.Documents
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0xce21ee7, 0x4f76, 0x4dd9, 0xbf, 0x91, 0x16, 0x3b, 0xec, 0xcf, 0x84, 0xbc), ExclusiveTo(typeof(TextElement)), WebHostHidden, Version(0x6020000)]
    internal interface ITextElementOverrides
    {
        void OnDisconnectVisualChildren();
    }
}

