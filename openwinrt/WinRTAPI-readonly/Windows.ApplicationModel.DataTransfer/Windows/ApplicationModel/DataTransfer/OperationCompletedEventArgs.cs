namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class OperationCompletedEventArgs : IOperationCompletedEventArgs
    {
        public DataPackageOperation Operation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackageOperation Windows.ApplicationModel.DataTransfer.IOperationCompletedEventArgs.Operation { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

