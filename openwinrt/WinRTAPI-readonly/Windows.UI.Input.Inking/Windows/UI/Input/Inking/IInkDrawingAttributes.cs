namespace Windows.UI.Input.Inking
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI;

    [Version(0x6020000), ExclusiveTo(typeof(InkDrawingAttributes)), Windows.Foundation.Metadata.Guid(0x97a2176c, 0x6774, 0x48ad, 0x84, 240, 0x48, 0xf5, 0xa9, 190, 0x74, 0xf9)]
    internal interface IInkDrawingAttributes
    {
        Windows.UI.Color Color { get; [param: In] set; }

        bool FitToCurve { get; [param: In] set; }

        bool IgnorePressure { get; [param: In] set; }

        PenTipShape PenTip { get; [param: In] set; }

        Windows.Foundation.Size Size { get; [param: In] set; }
    }
}

