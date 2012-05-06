namespace Windows.Data.Xml.Dom
{
    using System;
    using Windows.Foundation.Metadata;

    [Guid(0x8cb4e04d, 0x6d46, 0x4edb, 0xab, 0x73, 0xdf, 0x83, 0xc5, 0x1a, 0xd3, 0x97), Version(0x6020000), ExclusiveTo(typeof(DtdNotation))]
    internal interface IDtdNotation : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
        object PublicId { [return: Variant] get; }

        object SystemId { [return: Variant] get; }
    }
}

