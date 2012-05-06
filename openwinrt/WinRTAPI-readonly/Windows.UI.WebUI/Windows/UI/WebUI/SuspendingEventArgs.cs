namespace Windows.UI.WebUI
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.ApplicationModel;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class SuspendingEventArgs : ISuspendingEventArgs
    {
        public Windows.ApplicationModel.SuspendingOperation SuspendingOperation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.ApplicationModel.SuspendingOperation Windows.ApplicationModel.ISuspendingEventArgs.SuspendingOperation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

