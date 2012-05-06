namespace Windows.Security.Credentials.UI
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Static(typeof(ICredentialPickerStatics), 0x6020000), DualApiPartition(version=0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public static class CredentialPicker
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), DefaultOverload, Overload("PickWithOptionsAsync")]
        public static CredentialPickerOperation PickAsync([In] CredentialPickerOptions options);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("PickWithMessageAsync"), DefaultOverload]
        public static CredentialPickerOperation PickAsync([In] string targetName, [In] string message);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("PickWithCaptionAsync"), DefaultOverload]
        public static CredentialPickerOperation PickAsync([In] string targetName, [In] string message, [In] string caption);
    }
}

