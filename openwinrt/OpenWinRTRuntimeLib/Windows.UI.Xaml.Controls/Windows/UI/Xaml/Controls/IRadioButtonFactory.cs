namespace Windows.UI.Xaml.Controls
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(RadioButton)), WebHostHidden, Windows.Foundation.Metadata.Guid(0xf1d04933, 0x34e1, 0x4a5c, 0xb2, 0xae, 0xca, 0x3b, 0x1c, 11, 0x20, 0xde), Version(0x6020000)]
    internal interface IRadioButtonFactory
    {
        RadioButton CreateInstance([In] object outer, out object inner);
    }
}

