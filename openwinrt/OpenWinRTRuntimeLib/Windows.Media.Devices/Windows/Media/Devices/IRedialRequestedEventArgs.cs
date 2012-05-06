namespace Windows.Media.Devices
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(RedialRequestedEventArgs)), Version(0x6020000), Guid(0x7eb55209, 0x76ab, 0x4c31, 180, 14, 0x4b, 0x58, 0x37, 0x9d, 0x58, 12)]
    internal interface IRedialRequestedEventArgs
    {
        void Handled();
    }
}

