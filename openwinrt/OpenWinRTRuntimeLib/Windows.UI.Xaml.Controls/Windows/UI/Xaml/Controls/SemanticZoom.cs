namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [Threading(ThreadingModel.Both), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), ContentProperty(Name="ZoomedInView"), Static(typeof(ISemanticZoomStatics), 0x6020000), Version(0x6020000)]
    public sealed class SemanticZoom : Control, ISemanticZoom
    {
        public event SemanticZoomViewChangedEventHandler ViewChangeCompleted;

        public event SemanticZoomViewChangedEventHandler ViewChangeStarted;

        public event SemanticZoomViewChangedEventHandler Windows.UI.Xaml.Controls.ISemanticZoom.ViewChangeCompleted;

        public event SemanticZoomViewChangedEventHandler Windows.UI.Xaml.Controls.ISemanticZoom.ViewChangeStarted;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SemanticZoom();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ToggleActiveView();

        public bool CanChangeViews { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty CanChangeViewsProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsZoomedInViewActive { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsZoomedInViewActiveProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.ISemanticZoom.CanChangeViews { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.ISemanticZoom.IsZoomedInViewActive { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISemanticZoomInformation Windows.UI.Xaml.Controls.ISemanticZoom.ZoomedInView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISemanticZoomInformation Windows.UI.Xaml.Controls.ISemanticZoom.ZoomedOutView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ISemanticZoomInformation ZoomedInView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ZoomedInViewProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ISemanticZoomInformation ZoomedOutView { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ZoomedOutViewProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

