namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Threading(ThreadingModel.Both), Composable(typeof(IRelativeSourceFactory), CompositionType.Public, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Version(0x6020000)]
    public class RelativeSource : DependencyObject, IRelativeSource
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public RelativeSource();

        public RelativeSourceMode Mode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public RelativeSourceMode Windows.UI.Xaml.Data.IRelativeSource.Mode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

