namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000), Activatable(0x6020000), WebHostHidden, Threading(ThreadingModel.Both)]
    public sealed class BitmapCache : CacheMode, IBitmapCache
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public BitmapCache();
    }
}

