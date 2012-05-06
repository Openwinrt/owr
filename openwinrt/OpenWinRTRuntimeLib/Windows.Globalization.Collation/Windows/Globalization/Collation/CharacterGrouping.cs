namespace Windows.Globalization.Collation
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class CharacterGrouping : ICharacterGrouping
    {
        public string First { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Label { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.Collation.ICharacterGrouping.First { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.Globalization.Collation.ICharacterGrouping.Label { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

