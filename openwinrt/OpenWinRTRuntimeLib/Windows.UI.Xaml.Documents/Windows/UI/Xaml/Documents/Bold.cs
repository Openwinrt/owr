namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.Both), Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Activatable(0x6020000)]
    public sealed class Bold : Span, IBold
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Bold();
    }
}

