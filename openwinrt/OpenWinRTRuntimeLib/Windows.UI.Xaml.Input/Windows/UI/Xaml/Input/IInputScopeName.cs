namespace Windows.UI.Xaml.Input
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0xfd3e6997, 0x8fb, 0x4cba, 160, 0x21, 0x79, 0x2d, 0x75, 0x89, 0xfd, 90), WebHostHidden, Version(0x6020000), ExclusiveTo(typeof(InputScopeName))]
    internal interface IInputScopeName
    {
        InputScopeNameValue NameValue { get; [param: In] set; }
    }
}

