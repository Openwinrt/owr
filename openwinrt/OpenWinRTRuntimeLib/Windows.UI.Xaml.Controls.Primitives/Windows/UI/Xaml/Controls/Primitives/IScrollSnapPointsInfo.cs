namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls;

    [WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x1b5d1336, 0xe61b, 0x4d51, 190, 0x41, 0xfd, 0x8d, 220, 0x55, 0xc5, 140)]
    public interface IScrollSnapPointsInfo
    {
        event Windows.Foundation.EventHandler<object> HorizontalSnapPointsChanged;

        event Windows.Foundation.EventHandler<object> VerticalSnapPointsChanged;

        IVectorView<float> GetIrregularSnapPoints([In] Orientation orientation, [In] SnapPointsAlignment alignment);
        float GetRegularSnapPoints([In] Orientation orientation, [In] SnapPointsAlignment alignment, out float offset);

        bool AreHorizontalSnapPointsRegular { get; }

        bool AreVerticalSnapPointsRegular { get; }
    }
}

