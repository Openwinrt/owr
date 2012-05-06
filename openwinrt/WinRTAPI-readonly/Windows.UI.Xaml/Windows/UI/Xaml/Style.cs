namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;
    using Windows.UI.Xaml.Markup;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), ContentProperty(Name="Setters"), Activatable(typeof(IStyleFactory), 0x6020000), WebHostHidden, Activatable(0x6020000), Version(0x6020000)]
    public sealed class Style : DependencyObject, IStyle
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Style();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Style([In] TypeName targetType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Seal();

        public Style BasedOn { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool IsSealed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SetterBaseCollection Setters { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TypeName TargetType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Style Windows.UI.Xaml.IStyle.BasedOn { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.IStyle.IsSealed { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SetterBaseCollection Windows.UI.Xaml.IStyle.Setters { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TypeName Windows.UI.Xaml.IStyle.TargetType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

