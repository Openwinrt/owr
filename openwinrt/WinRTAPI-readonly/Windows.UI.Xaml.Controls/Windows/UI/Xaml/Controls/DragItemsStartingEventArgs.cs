namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.DataTransfer;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class DragItemsStartingEventArgs : IDragItemsStartingEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public DragItemsStartingEventArgs();

        public bool Cancel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DataPackage Data { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<object> Items { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.UI.Xaml.Controls.IDragItemsStartingEventArgs.Cancel { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public DataPackage Windows.UI.Xaml.Controls.IDragItemsStartingEventArgs.Data { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IVector<object> Windows.UI.Xaml.Controls.IDragItemsStartingEventArgs.Items { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

