namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class TargetApplicationChosenEventArgs : ITargetApplicationChosenEventArgs
    {
        public string ApplicationName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.DataTransfer.ITargetApplicationChosenEventArgs.ApplicationName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

