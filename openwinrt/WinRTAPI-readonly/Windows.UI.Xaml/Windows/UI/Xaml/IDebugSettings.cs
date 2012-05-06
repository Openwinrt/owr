namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(DebugSettings)), Windows.Foundation.Metadata.Guid(0x3d451f98, 0xc6a7, 0x4d17, 0x83, 0x98, 0xd8, 0x3a, 6, 0x71, 0x83, 0xd8)]
    internal interface IDebugSettings
    {
        bool EnableFrameRateCounter { get; [param: In] set; }

        bool IsBindingTracingEnabled { get; [param: In] set; }

        bool IsOverdrawHeatMapEnabled { get; [param: In] set; }
    }
}

