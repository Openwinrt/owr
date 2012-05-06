namespace Windows.Media.Transcoding
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [Guid(0x5f25dce, 0x994f, 0x4a34, 0x9d, 0x68, 0x97, 0xcc, 0xce, 0x17, 0x30, 0xd6), Version(0x6020000), ExclusiveTo(typeof(PrepareTranscodeResult))]
    internal interface IPrepareTranscodeResult
    {
        IAsyncActionWithProgress<double> TranscodeAsync();

        bool CanTranscode { get; }

        TranscodeFailureReason FailureReason { get; }
    }
}

