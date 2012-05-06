namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.Core;
    using Windows.Foundation.Metadata;
    using Windows.UI.Core;

    [Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Activatable(0x6020000), Version(0x6020000), WebHostHidden]
    public sealed class FrameworkView : Windows.UI.Xaml.IFrameworkView, Windows.ApplicationModel.Core.IFrameworkView
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public FrameworkView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Initialize([In] CoreApplicationView applicationView);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Load([In] string entryPoint);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Run();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetWindow([In] CoreWindow window);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Uninitialize();
    }
}

