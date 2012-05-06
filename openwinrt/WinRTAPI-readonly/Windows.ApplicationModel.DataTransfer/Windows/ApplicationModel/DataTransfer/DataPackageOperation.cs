namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum DataPackageOperation
    {
        Copy = 1,
        Link = 4,
        Move = 2,
        None = 0
    }
}

