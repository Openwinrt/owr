namespace Windows.ApplicationModel.DataTransfer
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(TargetApplicationChosenEventArgs)), Guid(0xca6fb8ac, 0x2987, 0x4ee3, 0x9c, 0x54, 0xd8, 0xaf, 0xbc, 0xb8, 0x6c, 0x1d)]
    internal interface ITargetApplicationChosenEventArgs
    {
        string ApplicationName { get; }
    }
}

