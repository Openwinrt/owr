namespace Windows.Foundation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [StructLayout(LayoutKind.Sequential), Version(0x6020000)]
    public struct EventRegistrationToken
    {
        public long Value;
    }
}

