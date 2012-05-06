namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IInlineFactory), CompositionType.Protected, 0x6020000), Version(0x6020000), Threading(ThreadingModel.Both)]
    public class Inline : TextElement, IInline
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected Inline();
    }
}

