namespace Windows.UI.Xaml.Controls.Primitives
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x2200df9, 0x21a, 0x484a, 0xa9, 0x3b, 15, 0x31, 2, 3, 20, 0xe5), Version(0x6020000), ExclusiveTo(typeof(RepeatButton)), WebHostHidden]
    internal interface IRepeatButton
    {
        int Delay { get; [param: In] set; }

        int Interval { get; [param: In] set; }
    }
}

