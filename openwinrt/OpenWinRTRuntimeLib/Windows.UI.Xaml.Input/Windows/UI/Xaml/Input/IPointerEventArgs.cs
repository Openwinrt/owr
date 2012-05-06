namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.System;
    using Windows.UI.Input;
    using Windows.UI.Xaml;

    [Windows.Foundation.Metadata.Guid(0xda628f0a, 0x9752, 0x49e2, 0xbd, 0xe2, 0x49, 0xec, 0xca, 0xb9, 0x19, 0x4d), Version(0x6020000), ExclusiveTo(typeof(PointerEventArgs)), WebHostHidden]
    internal interface IPointerEventArgs
    {
        PointerPoint GetCurrentPoint([In] UIElement relativeTo);
        IVector<PointerPoint> GetIntermediatePoints([In] UIElement relativeTo);

        bool Handled { get; [param: In] set; }

        VirtualKeyModifiers KeyModifiers { get; }

        Windows.UI.Xaml.Input.Pointer Pointer { get; }
    }
}

