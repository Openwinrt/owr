namespace System.Collections.Generic
{
    using System;
    using System.Collections;
    using System.Reflection;
    using System.Runtime.InteropServices;

    public interface IReadOnlyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
    {
        bool ContainsKey(TKey key);
        bool TryGetValue(TKey key, out TValue value);

        int Count { get; }

        TValue this[TKey key] { get; }

        IEnumerable<TKey> Keys { get; }

        IEnumerable<TValue> Values { get; }
    }
}

