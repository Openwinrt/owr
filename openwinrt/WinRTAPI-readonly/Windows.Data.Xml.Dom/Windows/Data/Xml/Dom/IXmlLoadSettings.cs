namespace Windows.Data.Xml.Dom
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Windows.Foundation.Metadata.Guid(0x58aa07a8, 0xfed6, 0x46f7, 180, 0xc5, 0xfb, 0x1b, 0xa7, 0x21, 8, 0xd6), ExclusiveTo(typeof(XmlLoadSettings))]
    internal interface IXmlLoadSettings
    {
        bool ElementContentWhiteSpace { get; [param: In] set; }

        uint MaxElementDepth { get; [param: In] set; }

        bool ProhibitDtd { get; [param: In] set; }

        bool ResolveExternals { get; [param: In] set; }

        bool ValidateOnParse { get; [param: In] set; }
    }
}

