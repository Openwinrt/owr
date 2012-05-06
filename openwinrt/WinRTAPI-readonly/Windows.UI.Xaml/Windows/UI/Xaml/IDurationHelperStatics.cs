namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DurationHelper)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xbc88093e, 0x3547, 0x4ec0, 0xb5, 0x19, 0xff, 0xa8, 0xf9, 0xc4, 0x83, 140), WebHostHidden]
    internal interface IDurationHelperStatics
    {
        Duration Add([In] Duration target, [In] Duration duration);
        int Compare([In] Duration duration1, [In] Duration duration2);
        bool Equals([In] Duration target, [In] Duration value);
        Duration FromTimeSpan([In] Windows.Foundation.TimeSpan timeSpan);
        bool GetHasTimeSpan([In] Duration target);
        Duration Subtract([In] Duration target, [In] Duration duration);

        Duration Automatic { get; }

        Duration Forever { get; }
    }
}

