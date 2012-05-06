namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), WebHostHidden, Windows.Foundation.Metadata.Guid(0x873b6c28, 0xcceb, 0x4b61, 0x86, 250, 0xb2, 0xce, 0xc3, 0x9c, 0xc2, 250), ExclusiveTo(typeof(DataTemplateKey))]
    internal interface IDataTemplateKey
    {
        object DataType { get; [param: In] set; }
    }
}

