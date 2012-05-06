namespace Windows.Media.PlayTo
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x99711324, 0xedc7, 0x4bf5, 0x91, 0xf6, 60, 0x86, 0x27, 0xdb, 0x59, 0xe5), ExclusiveTo(typeof(CurrentTimeChangeRequestedEventArgs)), Version(0x6020000)]
    internal interface ICurrentTimeChangeRequestedEventArgs
    {
        TimeSpan Time { get; }
    }
}

