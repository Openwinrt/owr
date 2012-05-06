namespace Windows.UI.Xaml.Documents
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Threading(ThreadingModel.Both), WebHostHidden, Version(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class LineBreak : Inline, ILineBreak
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public LineBreak();
    }
}

