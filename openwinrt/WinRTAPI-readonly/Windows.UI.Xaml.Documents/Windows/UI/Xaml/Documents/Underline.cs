namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class Underline : Span, IUnderline
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Underline();
    }
}

