namespace Windows.Media
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [Activatable(0x6020000), Threading(ThreadingModel.Both), Version(0x6020000)]
    public sealed class MediaExtensionManager : IMediaExtensionManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public MediaExtensionManager();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterAudioDecoder")]
        public void RegisterAudioDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterAudioDecoderWithSettings")]
        public void RegisterAudioDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterAudioEncoder")]
        public void RegisterAudioEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterAudioEncoderWithSettings")]
        public void RegisterAudioEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterByteStreamHandler")]
        public void RegisterByteStreamHandler([In] string activatableClassId, [In] string fileExtension, [In] string mimeType);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterByteStreamHandlerWithSettings")]
        public void RegisterByteStreamHandler([In] string activatableClassId, [In] string fileExtension, [In] string mimeType, [In] IPropertySet configuration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterSchemeHandler")]
        public void RegisterSchemeHandler([In] string activatableClassId, [In] string scheme);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterSchemeHandlerWithSettings")]
        public void RegisterSchemeHandler([In] string activatableClassId, [In] string scheme, [In] IPropertySet configuration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterVideoDecoder")]
        public void RegisterVideoDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterVideoDecoderWithSettings")]
        public void RegisterVideoDecoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterVideoEncoder")]
        public void RegisterVideoEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("RegisterVideoEncoderWithSettings")]
        public void RegisterVideoEncoder([In] string activatableClassId, [In] Guid inputSubtype, [In] Guid outputSubtype, [In] IPropertySet configuration);
    }
}

