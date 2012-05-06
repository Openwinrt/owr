namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class DataRequestDeferral : IDataRequestDeferral
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Complete();
    }
}

