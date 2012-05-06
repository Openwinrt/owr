namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class DataRequestedEventArgs : IDataRequestedEventArgs
    {
        public DataRequest Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataRequest Windows.ApplicationModel.DataTransfer.IDataRequestedEventArgs.Request { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

