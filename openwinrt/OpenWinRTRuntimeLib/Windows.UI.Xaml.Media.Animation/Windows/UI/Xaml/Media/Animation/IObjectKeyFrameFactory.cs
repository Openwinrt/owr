namespace Windows.UI.Xaml.Media.Animation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x1626143e, 0x3e6d, 0x44d8, 0x9b, 0x9a, 4, 0xae, 0xa7, 15, 0x84, 0x92), ExclusiveTo(typeof(ObjectKeyFrame)), WebHostHidden, Version(0x6020000)]
    internal interface IObjectKeyFrameFactory
    {
        ObjectKeyFrame CreateInstance([In] object outer, out object inner);
    }
}

