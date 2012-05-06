namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0xd5603377, 0x3dae, 0x4dcd, 0xaf, 9, 0xf9, 0x49, 0x8e, 0x9e, 0xc6, 0x59), ExclusiveTo(typeof(FontFamily)), Version(0x6020000)]
    internal interface IFontFamilyFactory
    {
        FontFamily CreateInstanceWithName([In] string familyName, [In] object outer, out object inner);
    }
}

