namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.DataTransfer;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x61d80247, 0x6cf6, 0x4fad, 0x84, 0xe2, 0xa5, 0xe8, 0x2e, 0x2d, 0x4c, 0xeb), ExclusiveTo(typeof(PrintTask)), Version(0x6020000)]
    internal interface IPrintTask
    {
        event TypedEventHandler<PrintTask, PrintTaskCompletedEventArgs> Completed;

        event TypedEventHandler<PrintTask, object> Previewing;

        event TypedEventHandler<PrintTask, PrintTaskProgressingEventArgs> Progressing;

        event TypedEventHandler<PrintTask, object> Submitting;

        PrintTaskOptions Options { get; }

        DataPackagePropertySet Properties { get; }

        IPrintDocumentSource Source { get; }
    }
}

