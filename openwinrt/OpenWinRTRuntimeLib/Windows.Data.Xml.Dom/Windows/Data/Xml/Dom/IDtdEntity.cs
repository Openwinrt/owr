namespace Windows.Data.Xml.Dom
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(DtdEntity)), Version(0x6020000), Guid(0x6a0b5ffc, 0x63b4, 0x480f, 0x9e, 0x6a, 0x8a, 0x92, 0x81, 0x6a, 0xad, 0xe4)]
    internal interface IDtdEntity : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
    {
        object NotationName { [return: Variant] get; }

        object PublicId { [return: Variant] get; }

        object SystemId { [return: Variant] get; }
    }
}

