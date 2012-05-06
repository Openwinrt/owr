namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Markup;

    [ContentProperty(Name="Child"), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both), Activatable(0x6020000)]
    public sealed class InlineUIContainer : Inline, IInlineUIContainer
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public InlineUIContainer();

        public UIElement Child { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UIElement Windows.UI.Xaml.Documents.IInlineUIContainer.Child { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

