namespace Windows.Graphics.Printing
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0xf9f067be, 0xf456, 0x41f0, 0x9c, 0x98, 0x5c, 0xe7, 0x3e, 0x85, 20, 0x10), ExclusiveTo(typeof(PrintTaskSourceRequestedArgs))]
    internal interface IPrintTaskSourceRequestedArgs
    {
        PrintTaskSourceRequestedDeferral GetDeferral();
        void SetSource([In] IPrintDocumentSource source);

        Windows.Foundation.DateTime Deadline { get; }
    }
}

