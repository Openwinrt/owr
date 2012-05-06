namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x4bce0016, 0xdd47, 0x4350, 140, 0xb0, 0xe1, 0x71, 0x60, 10, 200, 150), ExclusiveTo(typeof(Block))]
    internal interface IBlock
    {
        double LineHeight { get; [param: In] set; }

        Windows.UI.Xaml.LineStackingStrategy LineStackingStrategy { get; [param: In] set; }

        Windows.UI.Xaml.TextAlignment TextAlignment { get; [param: In] set; }
    }
}

