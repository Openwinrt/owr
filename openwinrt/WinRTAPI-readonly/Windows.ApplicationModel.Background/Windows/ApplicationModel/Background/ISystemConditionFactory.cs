namespace Windows.ApplicationModel.Background
{
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SystemCondition)), Version(0x6020000), Windows.Foundation.Metadata.Guid(0xd269d1f1, 0x5a7, 0x49ae, 0x87, 0xd7, 0x16, 0xb2, 0xb8, 0xb9, 0xa5, 0x53)]
    internal interface ISystemConditionFactory
    {
        SystemCondition Create([In] SystemConditionType conditionType);
    }
}

