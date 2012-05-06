namespace Windows.Globalization.Collation
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), DualApiPartition(version=0x6020000), Version(0x6020000), Activatable(0x6020000), Threading(ThreadingModel.Both)]
    public sealed class CharacterGroupings : ICharacterGroupings, IVectorView<CharacterGrouping>, IIterable<CharacterGrouping>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CharacterGroupings();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<CharacterGrouping> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public CharacterGrouping GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] CharacterGrouping[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] CharacterGrouping value, out uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string Lookup([In] string text);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

