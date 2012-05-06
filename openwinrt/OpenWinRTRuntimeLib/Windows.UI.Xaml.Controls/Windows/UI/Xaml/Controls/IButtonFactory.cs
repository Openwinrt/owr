namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x80a13c19, 0x843a, 0x451c, 140, 0xf5, 0x44, 0xc7, 1, 0xb0, 0xe2, 0x16), WebHostHidden, ExclusiveTo(typeof(Button))]
    internal interface IButtonFactory
    {
        Button CreateInstance([In] object outer, out object inner);
    }
}

