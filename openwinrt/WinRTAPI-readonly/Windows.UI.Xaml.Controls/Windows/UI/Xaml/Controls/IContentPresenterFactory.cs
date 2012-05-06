namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(ContentPresenter)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x3339d4f7, 0x4815, 0x44c4, 0x9f, 0x76, 0x68, 200, 0x38, 0x80, 0xef, 0x10), Version(0x6020000)]
    internal interface IContentPresenterFactory
    {
        ContentPresenter CreateInstance([In] object outer, out object inner);
    }
}

