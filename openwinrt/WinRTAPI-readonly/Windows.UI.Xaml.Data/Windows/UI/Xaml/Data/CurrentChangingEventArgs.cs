namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Composable(typeof(ICurrentChangingEventArgsFactory), CompositionType.Public, 0x6020000), WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both)]
    public class CurrentChangingEventArgs : ICurrentChangingEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CurrentChangingEventArgs();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CurrentChangingEventArgs([In] bool isCancelable);

        public bool Cancel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool IsCancelable { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Data.ICurrentChangingEventArgs.Cancel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public bool Windows.UI.Xaml.Data.ICurrentChangingEventArgs.IsCancelable { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

