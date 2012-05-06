namespace Windows.Devices.Sms
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct SmsEncodedLength
    {
        public uint SegmentCount;
        public uint CharacterCountLastSegment;
        public uint CharactersPerSegment;
        public uint ByteCountLastSegment;
        public uint BytesPerSegment;
    }
}

