namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [Threading(ThreadingModel.MTA), Version(0x6020000), Static(typeof(IBadgeUpdateManagerStatics), 0x6020000)]
    public static class BadgeUpdateManager
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateBadgeUpdaterForApplication")]
        public static BadgeUpdater CreateBadgeUpdaterForApplication();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime), Overload("CreateBadgeUpdaterForApplicationWithId")]
        public static BadgeUpdater CreateBadgeUpdaterForApplication([In] string applicationId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static BadgeUpdater CreateBadgeUpdaterForSecondaryTile([In] string tileId);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static XmlDocument GetTemplateContent([In] BadgeTemplateType type);
    }
}

