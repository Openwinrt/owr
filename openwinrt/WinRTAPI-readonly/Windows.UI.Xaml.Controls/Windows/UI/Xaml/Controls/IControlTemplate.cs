namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Xaml.Interop;

    [Windows.Foundation.Metadata.Guid(0xefd2418e, 0x41e0, 0x48bb, 0x8b, 130, 0x91, 0xed, 0xa1, 0xba, 0x3f, 0xe2), WebHostHidden, ExclusiveTo(typeof(ControlTemplate)), Version(0x6020000)]
    internal interface IControlTemplate
    {
        TypeName TargetType { get; [param: In] set; }
    }
}

