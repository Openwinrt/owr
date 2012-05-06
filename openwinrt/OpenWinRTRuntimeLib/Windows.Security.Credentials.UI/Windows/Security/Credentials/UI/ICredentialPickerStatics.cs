namespace Windows.Security.Credentials.UI
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(CredentialPicker)), Windows.Foundation.Metadata.Guid(0xaa3a5c73, 0xc9ea, 0x4782, 0x99, 0xfb, 230, 0xd7, 0xe9, 0x38, 0xe1, 0x2d)]
    internal interface ICredentialPickerStatics
    {
        [Overload("PickWithOptionsAsync"), DefaultOverload]
        CredentialPickerOperation PickAsync([In] CredentialPickerOptions options);
        [Overload("PickWithMessageAsync"), DefaultOverload]
        CredentialPickerOperation PickAsync([In] string targetName, [In] string message);
        [Overload("PickWithCaptionAsync"), DefaultOverload]
        CredentialPickerOperation PickAsync([In] string targetName, [In] string message, [In] string caption);
    }
}

