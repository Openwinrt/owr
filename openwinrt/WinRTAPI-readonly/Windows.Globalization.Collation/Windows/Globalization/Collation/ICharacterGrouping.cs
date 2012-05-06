namespace Windows.Globalization.Collation
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0xfae761bb, 0x805d, 0x4bb0, 0x95, 0xbb, 0xc1, 0xf7, 0xc3, 0xe8, 0xeb, 0x8e), ExclusiveTo(typeof(CharacterGrouping))]
    internal interface ICharacterGrouping
    {
        string First { get; }

        string Label { get; }
    }
}

