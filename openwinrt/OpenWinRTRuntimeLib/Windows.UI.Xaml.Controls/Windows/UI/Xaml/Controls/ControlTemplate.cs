namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Interop;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Activatable(0x6020000)]
    public sealed class ControlTemplate : FrameworkTemplate, IControlTemplate
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public ControlTemplate();

        public TypeName TargetType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public TypeName Windows.UI.Xaml.Controls.IControlTemplate.TargetType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

