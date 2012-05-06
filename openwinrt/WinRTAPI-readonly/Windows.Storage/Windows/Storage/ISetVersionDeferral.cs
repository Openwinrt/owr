namespace Windows.Storage
{
    using System;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SetVersionDeferral)), Guid(0x33508a2, 0x781a, 0x437a, 0xb0, 120, 0x3f, 50, 0xba, 220, 0xfe, 0x47), Version(0x6020000)]
    internal interface ISetVersionDeferral
    {
        void Complete();
    }
}

