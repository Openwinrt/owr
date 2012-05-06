namespace Windows.UI.Notifications
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Data.Xml.Dom;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(BadgeUpdateManager)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0x33400faa, 0x6dd5, 0x4105, 0xae, 0xbc, 0x9b, 80, 0xfc, 0xa4, 0x92, 0xda)]
    internal interface IBadgeUpdateManagerStatics
    {
        [Overload("CreateBadgeUpdaterForApplication")]
        BadgeUpdater CreateBadgeUpdaterForApplication();
        [Overload("CreateBadgeUpdaterForApplicationWithId")]
        BadgeUpdater CreateBadgeUpdaterForApplication([In] string applicationId);
        BadgeUpdater CreateBadgeUpdaterForSecondaryTile([In] string tileId);
        XmlDocument GetTemplateContent([In] BadgeTemplateType type);
    }
}

