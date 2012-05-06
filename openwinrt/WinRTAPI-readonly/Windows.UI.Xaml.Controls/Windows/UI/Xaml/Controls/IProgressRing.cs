namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Version(0x6020000), ExclusiveTo(typeof(ProgressRing)), Windows.Foundation.Metadata.Guid(0x6da5e49e, 0x6e9d, 0x425c, 0xbd, 0x7c, 2, 0x17, 0x3e, 0x39, 0x76, 0x3f), WebHostHidden]
    internal interface IProgressRing
    {
        bool IsActive { get; [param: In] set; }

        ProgressRingTemplateSettings TemplateSettings { get; }
    }
}

