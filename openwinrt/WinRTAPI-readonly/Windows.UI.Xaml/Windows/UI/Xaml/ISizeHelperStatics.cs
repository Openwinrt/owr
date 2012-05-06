namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(SizeHelper)), Windows.Foundation.Metadata.Guid(0x6286c5b2, 0xcf78, 0x4915, 170, 0x40, 0x76, 0, 0x4a, 0x16, 0x5f, 0x5e)]
    internal interface ISizeHelperStatics
    {
        bool Equals([In] Size target, [In] Size value);
        Size FromDimensions([In] float width, [In] float height);
        bool GetIsEmpty([In] Size target);

        Size Empty { get; }
    }
}

