namespace Windows.Networking.BackgroundTransfer
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;
    using Windows.Storage.Streams;

    [Windows.Foundation.Metadata.Guid(0xded06846, 0x90ca, 0x44fb, 0x8f, 0xb1, 0x12, 0x41, 0x54, 0xc0, 0xd5, 0x39), Version(0x6020000)]
    public interface IBackgroundTransferOperation
    {
        ResponseInformation GetResponseInformation();
        IInputStream GetResultStreamAt([In] ulong position);

        BackgroundTransferCostPolicy CostPolicy { get; [param: In] set; }

        string Group { get; }

        System.Guid Guid { get; }

        string Method { get; }

        Uri RequestedUri { get; }
    }
}

