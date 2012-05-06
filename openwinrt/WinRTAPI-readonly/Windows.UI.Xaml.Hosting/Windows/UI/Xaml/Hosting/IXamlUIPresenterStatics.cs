namespace Windows.UI.Xaml.Hosting
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(XamlUIPresenter)), Windows.Foundation.Metadata.Guid(0x71eaeac8, 0x45e1, 0x4192, 0x85, 170, 0x3a, 0x42, 0x2e, 0xdd, 0x23, 0xcf)]
    internal interface IXamlUIPresenterStatics
    {
        void SetHost([In] IXamlUIPresenterHost host);
    }
}

