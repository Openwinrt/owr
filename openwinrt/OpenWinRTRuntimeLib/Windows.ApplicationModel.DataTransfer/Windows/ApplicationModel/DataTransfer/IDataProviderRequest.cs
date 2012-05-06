namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xebbc7157, 0xd3c8, 0x47da, 0xac, 0xde, 0xf8, 0x23, 0x88, 0xd5, 0xf7, 0x16), ExclusiveTo(typeof(DataProviderRequest))]
    internal interface IDataProviderRequest
    {
        DataProviderDeferral GetDeferral();
        void SetData([In, HasVariant] object value);

        Windows.Foundation.DateTime Deadline { get; }

        string FormatId { get; }
    }
}

