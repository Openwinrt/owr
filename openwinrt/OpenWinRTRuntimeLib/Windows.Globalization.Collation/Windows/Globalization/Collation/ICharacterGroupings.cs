namespace Windows.Globalization.Collation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xb8d20a75, 0xd4cf, 0x4055, 0x80, 0xe5, 0xce, 0x16, 0x9c, 0x22, 100, 150), ExclusiveTo(typeof(CharacterGroupings)), Version(0x6020000)]
    internal interface ICharacterGroupings : IVectorView<CharacterGrouping>, IIterable<CharacterGrouping>
    {
        string Lookup([In] string text);
    }
}

