namespace Windows.UI.Xaml.Input
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x1eccd326, 0x8182, 0x4482, 130, 0x6a, 9, 0x18, 0xe9, 0xed, 0x9a, 0xf7), Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(FocusManager))]
    internal interface IFocusManagerStatics
    {
        object GetFocusedElement();
    }
}

