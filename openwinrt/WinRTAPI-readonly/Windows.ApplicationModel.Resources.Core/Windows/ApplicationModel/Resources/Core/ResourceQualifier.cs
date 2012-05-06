namespace Windows.ApplicationModel.Resources.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public sealed class ResourceQualifier : IResourceQualifier
    {
        public bool IsDefault { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool IsMatch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string QualifierName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string QualifierValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Score { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Resources.Core.IResourceQualifier.IsDefault { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.ApplicationModel.Resources.Core.IResourceQualifier.IsMatch { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Resources.Core.IResourceQualifier.QualifierName { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public string Windows.ApplicationModel.Resources.Core.IResourceQualifier.QualifierValue { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public double Windows.ApplicationModel.Resources.Core.IResourceQualifier.Score { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

