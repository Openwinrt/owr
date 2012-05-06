namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.ApplicationModel.DataTransfer;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [MarshalingBehavior(MarshalingType.FreeThreaded), Version(0x6020000)]
    public sealed class PrintTask : IPrintTask
    {
        public event TypedEventHandler<PrintTask, PrintTaskCompletedEventArgs> Completed;

        public event TypedEventHandler<PrintTask, object> Previewing;

        public event TypedEventHandler<PrintTask, PrintTaskProgressingEventArgs> Progressing;

        public event TypedEventHandler<PrintTask, object> Submitting;

        public event TypedEventHandler<PrintTask, PrintTaskCompletedEventArgs> Windows.Graphics.Printing.IPrintTask.Completed;

        public event TypedEventHandler<PrintTask, object> Windows.Graphics.Printing.IPrintTask.Previewing;

        public event TypedEventHandler<PrintTask, PrintTaskProgressingEventArgs> Windows.Graphics.Printing.IPrintTask.Progressing;

        public event TypedEventHandler<PrintTask, object> Windows.Graphics.Printing.IPrintTask.Submitting;

        public PrintTaskOptions Options { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackagePropertySet Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IPrintDocumentSource Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public PrintTaskOptions Windows.Graphics.Printing.IPrintTask.Options { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public DataPackagePropertySet Windows.Graphics.Printing.IPrintTask.Properties { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public IPrintDocumentSource Windows.Graphics.Printing.IPrintTask.Source { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

