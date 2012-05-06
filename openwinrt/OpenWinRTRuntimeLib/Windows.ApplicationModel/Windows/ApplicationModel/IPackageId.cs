namespace Windows.ApplicationModel
{
    using System;
    using Windows.Foundation.Metadata;
    using Windows.System;

    [ExclusiveTo(typeof(PackageId)), Version(0x6020000), Guid(0x1adb665e, 0x37c7, 0x4790, 0x99, 0x80, 0xdd, 0x7a, 0xe7, 0x4e, 0x8b, 0xb2)]
    internal interface IPackageId
    {
        ProcessorArchitecture Architecture { get; }

        string FamilyName { get; }

        string FullName { get; }

        string Name { get; }

        string Publisher { get; }

        string PublisherId { get; }

        string ResourceId { get; }

        PackageVersion Version { get; }
    }
}

