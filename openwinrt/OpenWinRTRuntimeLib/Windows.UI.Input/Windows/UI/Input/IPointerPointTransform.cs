namespace Windows.UI.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x4d5fe14f, 0xb87c, 0x4028, 0xbc, 0x9c, 0x59, 0xe9, 0x94, 0x7f, 0xb0, 0x56)]
    public interface IPointerPointTransform
    {
        Rect TransformBounds([In] Rect rect);
        bool TryTransform([In] Point inPoint, out Point outPoint);

        IPointerPointTransform Inverse { get; }
    }
}

