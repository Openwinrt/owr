namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Controls.Primitives;

    [Windows.Foundation.Metadata.Guid(0xae752c89, 0x67, 0x4963, 0xbf, 0x4c, 0x29, 0xdb, 12, 0x4a, 80, 0x7e), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(ProgressBar))]
    internal interface IProgressBar
    {
        bool IsIndeterminate { get; [param: In] set; }

        bool ShowError { get; [param: In] set; }

        bool ShowPaused { get; [param: In] set; }

        ProgressBarTemplateSettings TemplateSettings { get; }
    }
}

