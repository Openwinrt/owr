namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Core;

    [MarshalingBehavior(MarshalingType.FreeThreaded), WebHostHidden, Composable(typeof(IDependencyObjectFactory), CompositionType.Protected, 0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public class DependencyObject : IDependencyObject
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected DependencyObject();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ClearValue([In] DependencyProperty dp);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object GetAnimationBaseValue([In] DependencyProperty dp);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object GetValue([In] DependencyProperty dp);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public object ReadLocalValue([In] DependencyProperty dp);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetValue([In] DependencyProperty dp, [In] object value);

        public CoreDispatcher Dispatcher { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public CoreDispatcher Windows.UI.Xaml.IDependencyObject.Dispatcher { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

