namespace Windows.ApplicationModel.Contacts
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Static(typeof(IKnownContactFieldStatics), 0x6020000)]
    public static class KnownContactField
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static ContactFieldType ConvertNameToType([In] string name);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static string ConvertTypeToName([In] ContactFieldType type);

        public static string Email { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string InstantMessage { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string Location { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public static string PhoneNumber { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

