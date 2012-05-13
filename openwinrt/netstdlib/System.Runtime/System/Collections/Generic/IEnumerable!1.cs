namespace System.Collections.Generic
{
    using System.Collections;

    public interface IEnumerable<out T> : IEnumerable
    {
        IEnumerator<T> GetEnumerator();
    }
}

