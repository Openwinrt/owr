namespace Windows.Data.Json
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Threading(ThreadingModel.Both), Static(typeof(IJsonErrorStatics), 0x6020000), Version(0x6020000), DualApiPartition(version=0x6020000)]
    public static class JsonError
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static JsonErrorStatus GetStatus([In] int hresult);
    }
}

