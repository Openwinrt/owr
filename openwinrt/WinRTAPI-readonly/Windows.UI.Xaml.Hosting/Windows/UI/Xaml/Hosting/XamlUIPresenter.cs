namespace Windows.UI.Xaml.Hosting
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [WebHostHidden, Static(typeof(IXamlUIPresenterStatics), 0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class XamlUIPresenter : IXamlUIPresenter
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Present();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Render();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static void SetHost([In] IXamlUIPresenterHost host);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetSize([In] int width, [In] int height);

        public UIElement RootElement { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string ThemeKey { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string ThemeResourcesXaml { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public UIElement Windows.UI.Xaml.Hosting.IXamlUIPresenter.RootElement { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Hosting.IXamlUIPresenter.ThemeKey { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }

        public string Windows.UI.Xaml.Hosting.IXamlUIPresenter.ThemeResourcesXaml { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

