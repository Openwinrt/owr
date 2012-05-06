namespace Windows.UI.Xaml
{
    using System;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [WebHostHidden, Version(0x6020000), Guid(0x3c40ca8, 0x909e, 0x4117, 0x81, 0x1c, 0xa4, 0x52, 0x94, 150, 0xbd, 0xf1), ExclusiveTo(typeof(SetterBaseCollection))]
    internal interface ISetterBaseCollection : IVector<SetterBase>, IIterable<SetterBase>
    {
        bool IsSealed { get; }
    }
}

