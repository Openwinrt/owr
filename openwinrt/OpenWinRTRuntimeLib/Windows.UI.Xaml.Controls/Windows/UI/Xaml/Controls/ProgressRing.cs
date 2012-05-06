namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls.Primitives;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Activatable(0x6020000), Version(0x6020000), Static(typeof(IProgressRingStatics), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class ProgressRing : Control, IProgressRing
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ProgressRing();

        public bool IsActive { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public static DependencyProperty IsActiveProperty { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public ProgressRingTemplateSettings TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IProgressRing.IsActive { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public ProgressRingTemplateSettings Windows.UI.Xaml.Controls.IProgressRing.TemplateSettings { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

