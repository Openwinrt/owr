namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Markup;

    [Version(0x6020000), Composable(typeof(ISpanFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), ContentProperty(Name="Inlines"), WebHostHidden]
    public class Span : Inline, ISpan
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Span();

        public InlineCollection Inlines { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public InlineCollection Windows.UI.Xaml.Documents.ISpan.Inlines { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

