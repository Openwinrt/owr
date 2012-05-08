namespace Windows.Foundation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x44a9796f, 0x723e, 0x4fdf, 0xa2, 0x18, 3, 0x3e, 0x75, 0xb0, 0xc0, 0x84), Version(0x6020000), ExclusiveTo(typeof(Uri))]
    internal interface IUriRuntimeClassFactory
    {
        [Overload("CreateUri")]
        Uri CreateUri([In] string uri);
        [Overload("CreateWithRelativeUri")]
        Uri CreateUri([In] string baseUri, [In] string relativeUri);
    }
}

