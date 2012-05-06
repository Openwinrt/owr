namespace Windows.ApplicationModel.Background
{
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(SystemCondition)), Version(0x6020000), Guid(0xc15fb476, 0x89c5, 0x420b, 0xab, 0xd3, 0xfb, 0x30, 0x30, 0x47, 0x21, 40)]
    internal interface ISystemCondition : IBackgroundCondition
    {
        SystemConditionType ConditionType { get; }
    }
}

