namespace Windows.Foundation.Diagnostics
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x16369792, 0xb03e, 0x4ba1, 0x8b, 0xb8, 210, 0x8f, 0x4a, 180, 210, 0xc0), Version(0x6020000)]
    public interface IErrorReportingSettings
    {
        ErrorOptions GetErrorOptions();
        void SetErrorOptions([In] ErrorOptions value);
    }
}

