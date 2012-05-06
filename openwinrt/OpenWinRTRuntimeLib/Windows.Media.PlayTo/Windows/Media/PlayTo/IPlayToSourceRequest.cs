namespace Windows.Media.PlayTo
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(PlayToSourceRequest)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf8584665, 0x64f4, 0x44a0, 0xac, 13, 70, 0x8d, 0x2b, 0x8f, 0xda, 0x83)]
    internal interface IPlayToSourceRequest
    {
        void DisplayErrorString([In] string errorString);
        PlayToSourceDeferral GetDeferral();
        void SetSource([In] PlayToSource value);

        Windows.Foundation.DateTime Deadline { get; }
    }
}

