namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both), Version(0x6020000)]
    public sealed class NotifyEventArgs : INotifyEventArgs
    {
        public string Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Controls.INotifyEventArgs.Value { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

