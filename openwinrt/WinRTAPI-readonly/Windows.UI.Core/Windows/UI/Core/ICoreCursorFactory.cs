namespace Windows.UI.Core
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xf6359621, 0xa79d, 0x4ed3, 140, 50, 0xa9, 0xef, 0x9d, 0x6b, 0x76, 0xa4), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(CoreCursor))]
    internal interface ICoreCursorFactory
    {
        CoreCursor CreateCursor([In] CoreCursorType type, [In] uint id);
    }
}

