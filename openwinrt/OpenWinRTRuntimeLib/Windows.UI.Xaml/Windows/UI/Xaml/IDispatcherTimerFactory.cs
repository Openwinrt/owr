namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DispatcherTimer)), Windows.Foundation.Metadata.Guid(0xe9961e6e, 0x3626, 0x403a, 0xaf, 0xe0, 4, 13, 0x58, 0x16, 0x56, 50), WebHostHidden, Version(0x6020000)]
    internal interface IDispatcherTimerFactory
    {
        DispatcherTimer CreateInstance([In] object outer, out object inner);
    }
}

