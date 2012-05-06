namespace Windows.ApplicationModel.Background
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Version(0x6020000), Activatable(typeof(ISystemConditionFactory), 0x6020000), Threading(ThreadingModel.Both)]
    public sealed class SystemCondition : ISystemCondition, IBackgroundCondition
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public SystemCondition([In] SystemConditionType conditionType);

        public SystemConditionType ConditionType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public SystemConditionType Windows.ApplicationModel.Background.ISystemCondition.ConditionType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

