namespace Windows.UI.Xaml.Automation.Provider
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x79670fdd, 0xf6a9, 0x4a65, 0xaf, 0x17, 0x86, 0x1d, 0xb7, 0x99, 0xa2, 0xda)]
    public interface ITransformProvider
    {
        void Move([In] double x, [In] double y);
        void Resize([In] double width, [In] double height);
        void Rotate([In] double degrees);

        bool CanMove { get; }

        bool CanResize { get; }

        bool CanRotate { get; }
    }
}

