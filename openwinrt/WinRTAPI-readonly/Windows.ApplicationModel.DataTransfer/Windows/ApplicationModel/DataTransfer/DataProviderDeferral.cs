namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class DataProviderDeferral : IDataProviderDeferral
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Complete();
    }
}

