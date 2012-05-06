namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [Composable(typeof(IProgressBarFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Static(typeof(IProgressBarStatics), 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public class ProgressBar : RangeBase, IProgressBar
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ProgressBar();

        public bool IsIndeterminate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsIndeterminateProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool ShowError { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ShowErrorProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool ShowPaused { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty ShowPausedProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ProgressBarTemplateSettings TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IProgressBar.IsIndeterminate { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IProgressBar.ShowError { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Controls.IProgressBar.ShowPaused { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ProgressBarTemplateSettings Windows.UI.Xaml.Controls.IProgressBar.TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

