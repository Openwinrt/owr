namespace Windows.UI.Xaml.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(TransformGroup)), WebHostHidden, Windows.Foundation.Metadata.Guid(0x63418ccc, 0x8d2d, 0x4737, 0xb9, 0x51, 0x2a, 0xfc, 0xe1, 0xdd, 0xc4, 0xc4), Version(0x6020000)]
    internal interface ITransformGroup
    {
        TransformCollection Children { get; [param: In] set; }

        Matrix Value { get; }
    }
}

