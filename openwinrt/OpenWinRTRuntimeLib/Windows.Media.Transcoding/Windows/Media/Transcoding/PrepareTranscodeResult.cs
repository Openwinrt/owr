namespace Windows.Media.Transcoding
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), DualApiPartition(version=0x6020000)]
    public sealed class PrepareTranscodeResult : IPrepareTranscodeResult
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IAsyncActionWithProgress<double> TranscodeAsync();

        public bool CanTranscode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TranscodeFailureReason FailureReason { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public bool Windows.Media.Transcoding.IPrepareTranscodeResult.CanTranscode { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public TranscodeFailureReason Windows.Media.Transcoding.IPrepareTranscodeResult.FailureReason { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

