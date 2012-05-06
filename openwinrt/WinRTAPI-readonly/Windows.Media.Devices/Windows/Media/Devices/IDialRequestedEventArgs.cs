namespace Windows.Media.Devices
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Guid(0x37b929e, 0x953c, 0x4286, 0x88, 0x66, 0x4f, 15, 0x37, 0x6c, 0x85, 90), ExclusiveTo(typeof(DialRequestedEventArgs))]
    internal interface IDialRequestedEventArgs
    {
        void Handled();

        object Contact { get; }
    }
}

