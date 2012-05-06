namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Markup;

    [Activatable(0x6020000), ContentProperty(Name="Inlines"), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class Paragraph : Block, IParagraph
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Paragraph();

        public InlineCollection Inlines { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public InlineCollection Windows.UI.Xaml.Documents.IParagraph.Inlines { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

