namespace Windows.UI.Xaml
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SetterBase)), Version(0x6020000), WebHostHidden, Guid(0x418be27c, 0x2ac4, 0x4f22, 0x80, 0x97, 0xde, 0xa3, 0xae, 0xeb, 0x2f, 0xb3)]
    internal interface ISetterBase
    {
        bool IsSealed { get; }
    }
}

