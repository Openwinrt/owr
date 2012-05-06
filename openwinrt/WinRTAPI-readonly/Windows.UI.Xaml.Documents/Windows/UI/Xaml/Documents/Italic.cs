namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Activatable(0x6020000), Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class Italic : Span, IItalic
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Italic();
    }
}

