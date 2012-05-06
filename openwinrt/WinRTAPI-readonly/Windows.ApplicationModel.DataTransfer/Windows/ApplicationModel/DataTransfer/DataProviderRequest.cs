namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class DataProviderRequest : IDataProviderRequest
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataProviderDeferral GetDeferral();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetData([In, HasVariant] object value);

        public Windows.Foundation.DateTime Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string FormatId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public Windows.Foundation.DateTime Windows.ApplicationModel.DataTransfer.IDataProviderRequest.Deadline { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.DataTransfer.IDataProviderRequest.FormatId { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

