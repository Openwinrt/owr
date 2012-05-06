namespace Windows.Foundation
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x30d5a829, 0x7fa4, 0x4026, 0x83, 0xbb, 0xd7, 0x5b, 0xae, 0x4e, 0xa9, 0x9e), Version(0x6020000)]
    public interface IClosable
    {
        void Close();
    }
}

