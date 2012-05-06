namespace Windows.Media.PlayTo
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x64e6a887, 0x3982, 0x4f3b, 0xba, 0x20, 0x61, 0x55, 0xe4, 0x35, 50, 0x5b), ExclusiveTo(typeof(PlayToManager)), Version(0x6020000)]
    internal interface IPlayToManagerStatics
    {
        PlayToManager GetForCurrentView();
        void ShowPlayToUI();
    }
}

