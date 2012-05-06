namespace Windows.UI.Core
{
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.System;
    using Windows.UI.Input;

    [WebHostHidden, Guid(0x920d9cb1, 0xa5fc, 0x4a21, 140, 9, 0x49, 0xdf, 230, 0xff, 0xe2, 0x5f), Version(0x6020000)]
    public interface IPointerEventArgs : ICoreWindowEventArgs
    {
        IVector<PointerPoint> GetIntermediatePoints();

        PointerPoint CurrentPoint { get; }

        VirtualKeyModifiers KeyModifiers { get; }
    }
}

