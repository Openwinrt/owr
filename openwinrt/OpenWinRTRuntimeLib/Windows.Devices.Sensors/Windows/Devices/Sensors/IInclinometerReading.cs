namespace Windows.Devices.Sensors
{
    using System;
    using Windows.Foundation;
    using Windows.Foundation.Metadata;

    [ExclusiveTo(typeof(InclinometerReading)), Guid(0x9f44f055, 0xb6f6, 0x497f, 0xb1, 0x27, 0x1a, 0x77, 0x5e, 80, 20, 0x58), Version(0x6020000)]
    internal interface IInclinometerReading
    {
        float PitchDegrees { get; }

        float RollDegrees { get; }

        Windows.Foundation.DateTime Timestamp { get; }

        float YawDegrees { get; }
    }
}

