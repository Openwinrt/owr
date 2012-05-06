namespace Windows.UI.ViewManagement
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Static(typeof(IApplicationViewStatics), 0x6020000), Threading(ThreadingModel.STA), Version(0x6020000)]
    public sealed class ApplicationView : IApplicationView
    {
        public event TypedEventHandler<ApplicationView, ApplicationViewStateChangedEventArgs> ViewStateChanged;

        public event TypedEventHandler<ApplicationView, ApplicationViewStateChangedEventArgs> Windows.UI.ViewManagement.IApplicationView.ViewStateChanged;

        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ApplicationView GetForCurrentView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool TryUnsnap();

        public static ApplicationViewState Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

