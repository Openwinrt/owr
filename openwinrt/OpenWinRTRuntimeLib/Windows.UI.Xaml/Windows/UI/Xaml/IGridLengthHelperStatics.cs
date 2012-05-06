namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(GridLengthHelper)), Windows.Foundation.Metadata.Guid(0x9d457b9b, 0x19f, 0x4266, 0x88, 0x72, 0x21, 0x5f, 0x19, 0x8f, 0x6a, 0x9d), Version(0x6020000), WebHostHidden]
    internal interface IGridLengthHelperStatics
    {
        bool Equals([In] GridLength target, [In] GridLength value);
        GridLength FromPixels([In] double pixels);
        GridLength FromValueAndType([In] double value, [In] GridUnitType type);
        bool GetIsAbsolute([In] GridLength target);
        bool GetIsAuto([In] GridLength target);
        bool GetIsStar([In] GridLength target);

        GridLength Auto { get; }
    }
}

