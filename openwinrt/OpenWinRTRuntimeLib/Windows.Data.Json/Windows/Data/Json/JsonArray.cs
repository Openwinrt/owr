namespace Windows.Data.Json
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows.Foundation.Collections;
    using Windows.Foundation.Metadata;

    [DualApiPartition(version=0x6020000), WebHostHidden, Static(typeof(IJsonArrayStatics), 0x6020000), Activatable(0x6020000), Version(0x6020000), Threading(ThreadingModel.Both), MarshalingBehavior(MarshalingType.FreeThreaded)]
    public sealed class JsonArray : IJsonArray, IJsonValue, IVector<IJsonValue>, IIterable<IJsonValue>
    {
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonArray();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Append([In] IJsonValue value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void Clear();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IIterator<IJsonValue> First();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonArray GetArray();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonArray GetArrayAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IJsonValue GetAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool GetBoolean();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool GetBooleanAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public uint GetMany([In] uint startIndex, [Out] IJsonValue[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public double GetNumber();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public double GetNumberAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonObject GetObject();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public JsonObject GetObjectAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetString();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string GetStringAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public IVectorView<IJsonValue> GetView();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public bool IndexOf([In] IJsonValue value, out uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void InsertAt([In] uint index, [In] IJsonValue value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static JsonArray Parse([In] string input);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAt([In] uint index);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void RemoveAtEnd();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void ReplaceAll([In] IJsonValue[] items);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public void SetAt([In] uint index, [In] IJsonValue value);
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public string Stringify();
        [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)]
        public static bool TryParse([In] string input, out JsonArray result);

        public uint Size { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public JsonValueType ValueType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }

        public JsonValueType Windows.Data.Json.IJsonValue.ValueType { [MethodImpl(0, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

