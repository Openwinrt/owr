namespace Windows.UI.Text
{
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, ExclusiveTo(typeof(FontWeights)), Guid(0xb3b579d5, 0x1ba9, 0x48eb, 0x9d, 0xad, 0xc0, 0x95, 0xe8, 0xc2, 0x3b, 0xa3)]
    internal interface IFontWeightsStatics
    {
        FontWeight Black { get; }

        FontWeight Bold { get; }

        FontWeight ExtraBlack { get; }

        FontWeight ExtraBold { get; }

        FontWeight ExtraLight { get; }

        FontWeight Light { get; }

        FontWeight Medium { get; }

        FontWeight Normal { get; }

        FontWeight SemiBold { get; }

        FontWeight SemiLight { get; }

        FontWeight Thin { get; }
    }
}

