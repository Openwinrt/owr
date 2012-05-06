namespace Windows.UI.Xaml.Hosting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xa714944a, 0x1619, 0x4fc6, 0xb3, 0x1b, 0x89, 0x51, 0x2e, 240, 0x22, 0xa2), ExclusiveTo(typeof(XamlUIPresenter)), WebHostHidden]
    internal interface IXamlUIPresenter
    {
        void Present();
        void Render();
        void SetSize([In] int width, [In] int height);

        UIElement RootElement { get; [param: In] set; }

        string ThemeKey { get; [param: In] set; }

        string ThemeResourcesXaml { get; [param: In] set; }
    }
}

