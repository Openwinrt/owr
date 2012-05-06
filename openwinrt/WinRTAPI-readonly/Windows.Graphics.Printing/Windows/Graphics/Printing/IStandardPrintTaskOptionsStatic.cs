namespace Windows.Graphics.Printing
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(StandardPrintTaskOptions)), Version(0x6020000), Guid(0xb4483d26, 0xdd0, 0x4cd4, 0xba, 0xff, 0x93, 15, 0xc7, 0xd6, 0xa5, 0x74)]
    internal interface IStandardPrintTaskOptionsStatic
    {
        string Binding { get; }

        string Collation { get; }

        string ColorMode { get; }

        string Copies { get; }

        string Duplex { get; }

        string HolePunch { get; }

        string InputBin { get; }

        string MediaSize { get; }

        string MediaType { get; }

        string NUp { get; }

        string Orientation { get; }

        string PrintQuality { get; }

        string Staple { get; }
    }
}

