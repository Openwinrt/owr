namespace Windows.Devices.Portable
{
    using System;
    using Windows.Foundation.Metadata;

    [Version(0x6020000)]
    public enum ServiceDeviceType
    {
        CalendarService,
        ContactsService,
        DeviceStatusService,
        NotesService,
        RingtonesService,
        SmsService,
        TasksService
    }
}

