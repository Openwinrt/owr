namespace Windows.UI.Xaml.Media
{
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(RenderingEventArgs)), Guid(0x5bf7d30d, 0x9748, 0x4aed, 0x83, 0x80, 0xd7, 0x89, 14, 0xb7, 0x76, 160)]
    internal interface IRenderingEventArgs
    {
        TimeSpan RenderingTime { get; }
    }
}

