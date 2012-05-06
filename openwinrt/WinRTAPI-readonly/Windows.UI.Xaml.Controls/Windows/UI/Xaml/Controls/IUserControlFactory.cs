namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(UserControl)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0x38b1ed92, 0xa28a, 0x4972, 0x93, 0xdf, 0xf4, 0xf7, 0x59, 0xb8, 0xaf, 210)]
    internal interface IUserControlFactory
    {
        UserControl CreateInstance([In] object outer, out object inner);
    }
}

