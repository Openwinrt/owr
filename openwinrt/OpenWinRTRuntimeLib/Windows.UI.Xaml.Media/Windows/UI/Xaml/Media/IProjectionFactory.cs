namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(Projection)), WebHostHidden, Version(0x6020000), Windows.Foundation.Metadata.Guid(0xc4f29cab, 0x60ad, 0x4f24, 0xbd, 0x27, 0x9d, 0x69, 0xc3, 0x12, 0x7c, 0x9a)]
    internal interface IProjectionFactory
    {
        Projection CreateInstance([In] object outer, out object inner);
    }
}

