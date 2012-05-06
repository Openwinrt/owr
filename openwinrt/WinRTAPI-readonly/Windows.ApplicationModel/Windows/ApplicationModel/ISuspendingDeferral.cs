namespace Windows.ApplicationModel
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x59140509, 0x8bc9, 0x4eb4, 0xb6, 0x36, 0xda, 0xbd, 0xc4, 0xf4, 0x6f, 0x66)]
    public interface ISuspendingDeferral
    {
        void Complete();
    }
}

