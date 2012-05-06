namespace Windows.ApplicationModel.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(CoreApplication)), Guid(0x518dc408, 0xc077, 0x475b, 0x80, 0x9e, 11, 0xc0, 0xc5, 0x7e, 0x4b, 0x74), WebHostHidden, Version(0x6020000)]
    internal interface ICoreApplicationUseCount
    {
        void DecrementApplicationUseCount();
        void IncrementApplicationUseCount();
    }
}

