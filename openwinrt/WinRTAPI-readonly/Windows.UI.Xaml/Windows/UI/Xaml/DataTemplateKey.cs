namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(IDataTemplateKeyFactory), CompositionType.Public, 0x6020000), Version(0x6020000), WebHostHidden, Threading(ThreadingModel.Both)]
    public class DataTemplateKey : IDataTemplateKey
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataTemplateKey();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DataTemplateKey([In] object dataType);

        public object DataType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public object Windows.UI.Xaml.IDataTemplateKey.DataType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

