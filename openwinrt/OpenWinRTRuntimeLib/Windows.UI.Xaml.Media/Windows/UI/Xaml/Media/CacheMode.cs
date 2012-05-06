namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Version(0x6020000), Composable(typeof(ICacheModeFactory), CompositionType.Protected, 0x6020000), MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both)]
    public class CacheMode : DependencyObject, ICacheMode
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        protected CacheMode();
    }
}

