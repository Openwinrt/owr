namespace Windows.Foundation
{
    using System;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Metadata;

    [Windows.Foundation.Metadata.Guid(0x4bd682dd, 0x7554, 0x40e9, 0x9a, 0x9b, 130, 0x65, 0x4e, 0xde, 0x7e, 0x62), Version(0x6020000)]
    public interface IPropertyValue
    {
        bool GetBoolean();
        void GetBooleanArray(out bool[] value);
        char GetChar16();
        void GetChar16Array(out char[] value);
        Windows.Foundation.DateTime GetDateTime();
        void GetDateTimeArray(out Windows.Foundation.DateTime[] value);
        double GetDouble();
        void GetDoubleArray(out double[] value);
        Guid GetGuid();
        void GetGuidArray(out Guid[] value);
        void GetInspectableArray(out object[] value);
        short GetInt16();
        void GetInt16Array(out short[] value);
        int GetInt32();
        void GetInt32Array(out int[] value);
        long GetInt64();
        void GetInt64Array(out long[] value);
        Point GetPoint();
        void GetPointArray(out Point[] value);
        Rect GetRect();
        void GetRectArray(out Rect[] value);
        float GetSingle();
        void GetSingleArray(out float[] value);
        Size GetSize();
        void GetSizeArray(out Size[] value);
        string GetString();
        void GetStringArray(out string[] value);
        Windows.Foundation.TimeSpan GetTimeSpan();
        void GetTimeSpanArray(out Windows.Foundation.TimeSpan[] value);
        ushort GetUInt16();
        void GetUInt16Array(out ushort[] value);
        uint GetUInt32();
        void GetUInt32Array(out uint[] value);
        ulong GetUInt64();
        void GetUInt64Array(out ulong[] value);
        byte GetUInt8();
        void GetUInt8Array(out byte[] value);

        bool IsNumericScalar { get; }

        PropertyType Type { get; }
    }
}

