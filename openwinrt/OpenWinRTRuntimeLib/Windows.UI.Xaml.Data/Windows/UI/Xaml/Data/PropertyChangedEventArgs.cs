namespace Windows.UI.Xaml.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Composable(typeof(IPropertyChangedEventArgsFactory), CompositionType.Public, 0x6020000)]
    public class PropertyChangedEventArgs : IPropertyChangedEventArgs
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public PropertyChangedEventArgs([In] string name);

        public string PropertyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.UI.Xaml.Data.IPropertyChangedEventArgs.PropertyName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

