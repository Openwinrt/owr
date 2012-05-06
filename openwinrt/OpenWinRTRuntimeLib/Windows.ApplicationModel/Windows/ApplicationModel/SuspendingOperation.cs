﻿namespace Windows.ApplicationModel
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class SuspendingOperation : ISuspendingOperation
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SuspendingDeferral GetDeferral();

        public Windows.Foundation.DateTime Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.ApplicationModel.ISuspendingOperation.Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

