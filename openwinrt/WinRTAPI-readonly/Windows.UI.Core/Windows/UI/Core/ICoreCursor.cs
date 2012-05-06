namespace Windows.UI.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CoreCursor)), Guid(0x96893acf, 0x111d, 0x442c, 0x8a, 0x77, 0xb8, 0x79, 0x92, 0xf8, 0xe2, 0xd6), WebHostHidden, Version(0x6020000)]
    internal interface ICoreCursor
    {
        uint Id { get; }

        CoreCursorType Type { get; }
    }
}

