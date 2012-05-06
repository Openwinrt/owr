namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.ApplicationModel.Core;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Threading(ThreadingModel.Both), Activatable(0x6020000), Version(0x6020000), WebHostHidden]
    public sealed class FrameworkViewSource : Windows.UI.Xaml.IFrameworkViewSource, Windows.ApplicationModel.Core.IFrameworkViewSource
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FrameworkViewSource();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public Windows.ApplicationModel.Core.IFrameworkView CreateView();
    }
}

