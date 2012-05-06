namespace Windows.Security.Credentials
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x6ab18989, 0xc720, 0x41a7, 0xa6, 0xc1, 0xfe, 0xad, 0xb3, 0x63, 0x29, 160), Version(0x6020000), ExclusiveTo(typeof(PasswordCredential))]
    internal interface IPasswordCredential
    {
        void RetrievePassword();

        string Password { get; [param: In] set; }

        IPropertySet Properties { get; }

        string Resource { get; [param: In] set; }

        string UserName { get; [param: In] set; }
    }
}

