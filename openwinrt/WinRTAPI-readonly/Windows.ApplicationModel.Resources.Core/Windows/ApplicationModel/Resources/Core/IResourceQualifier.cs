namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), ExclusiveTo(typeof(ResourceQualifier)), Guid(0x785da5b2, 0x4afd, 0x4376, 0xa8, 0x88, 0xc5, 0xf9, 0xa6, 0xb7, 160, 0x5c)]
    internal interface IResourceQualifier
    {
        bool IsDefault { get; }

        bool IsMatch { get; }

        string QualifierName { get; }

        string QualifierValue { get; }

        double Score { get; }
    }
}

