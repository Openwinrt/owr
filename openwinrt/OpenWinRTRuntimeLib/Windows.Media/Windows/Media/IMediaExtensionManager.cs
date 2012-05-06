namespace Windows.Media
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4a25eaf5, 0x242d, 0x4dfb, 0x97, 0xf4, 0x69, 0xb7, 0xc4, 0x25, 0x76, 0xff), ExclusiveTo(typeof(MediaExtensionManager)), Version(0x6020000)]
    internal interface IMediaExtensionManager
    {
        [Overload("RegisterAudioDecoder")]
        void RegisterAudioDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
        [Overload("RegisterAudioDecoderWithSettings")]
        void RegisterAudioDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
        [Overload("RegisterAudioEncoder")]
        void RegisterAudioEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
        [Overload("RegisterAudioEncoderWithSettings")]
        void RegisterAudioEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
        [Overload("RegisterByteStreamHandler")]
        void RegisterByteStreamHandler([In] string activatableClassId, [In] string fileExtension, [In] string mimeType);
        [Overload("RegisterByteStreamHandlerWithSettings")]
        void RegisterByteStreamHandler([In] string activatableClassId, [In] string fileExtension, [In] string mimeType, [In] IPropertySet configuration);
        [Overload("RegisterSchemeHandler")]
        void RegisterSchemeHandler([In] string activatableClassId, [In] string scheme);
        [Overload("RegisterSchemeHandlerWithSettings")]
        void RegisterSchemeHandler([In] string activatableClassId, [In] string scheme, [In] IPropertySet configuration);
        [Overload("RegisterVideoDecoder")]
        void RegisterVideoDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
        [Overload("RegisterVideoDecoderWithSettings")]
        void RegisterVideoDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
        [Overload("RegisterVideoEncoder")]
        void RegisterVideoEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
        [Overload("RegisterVideoEncoderWithSettings")]
        void RegisterVideoEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
    }
}

