namespace Windows.UI.Xaml
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;
    using Windows.UI.Core;

    [WebHostHidden, Windows.Foundation.Metadata.Guid(0x5c526665, 0xf60e, 0x4912, 0xaf, 0x59, 0x5f, 0xe0, 0x68, 15, 8, 0x9d), ExclusiveTo(typeof(DependencyObject)), Version(0x6020000)]
    internal interface IDependencyObject
    {
        void ClearValue([In] DependencyProperty dp);
        object GetAnimationBaseValue([In] DependencyProperty dp);
        object GetValue([In] DependencyProperty dp);
        object ReadLocalValue([In] DependencyProperty dp);
        void SetValue([In] DependencyProperty dp, [In] object value);

        CoreDispatcher Dispatcher { get; }
    }
}

