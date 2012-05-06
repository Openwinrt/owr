namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class DataRequest : IDataRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void FailWithDisplayText([In] string value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataRequestDeferral GetDeferral();

        public DataPackage Data { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.DateTime Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackage Windows.ApplicationModel.DataTransfer.IDataRequest.Data { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public Windows.Foundation.DateTime Windows.ApplicationModel.DataTransfer.IDataRequest.Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

