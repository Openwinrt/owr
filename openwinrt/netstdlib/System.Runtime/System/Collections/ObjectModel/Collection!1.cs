namespace System.Collections.ObjectModel
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;

    public class Collection<T> : IList<T>, ICollection<T>, IReadOnlyList<T>, IEnumerable<T>, IList, ICollection, IEnumerable
    {
        public Collection()
        {
            base..ctor();
            return;
        }

        public Collection(IList<T> list)
        {
            base..ctor();
            return;
        }

        public void Add(T item)
        {
        }

        public void Clear()
        {
        }

        protected virtual void ClearItems()
        {
        }

        public bool Contains(T item)
        {
            return 0;
        }

        public void CopyTo(T[] array, int index)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            return null;
        }

        public int IndexOf(T item)
        {
            return 0;
        }

        public void Insert(int index, T item)
        {
        }

        protected virtual void InsertItem(int index, T item)
        {
        }

        public bool Remove(T item)
        {
            return 0;
        }

        public void RemoveAt(int index)
        {
        }

        protected virtual void RemoveItem(int index)
        {
        }

        protected virtual void SetItem(int index, T item)
        {
        }

        void ICollection.CopyTo(Array array, int index)
        {
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }

        int IList.Add(object value)
        {
            return 0;
        }

        bool IList.Contains(object value)
        {
            return 0;
        }

        int IList.IndexOf(object value)
        {
            return 0;
        }

        void IList.Insert(int index, object value)
        {
        }

        void IList.Remove(object value)
        {
        }

        public int Count
        {
            get
            {
                return 0;
            }
        }

        public T this[int index]
        {
            get

            {
                T local;
                return default(T);
            }
            set
            {
            }
        }

        protected IList<T> Items
        {
            get
            {
                return null;
            }
        }

        bool ICollection<T>.IsReadOnly
        {
            get
            {
                return 0;
            }
        }

        bool ICollection.IsSynchronized
        {
            get
            {
                return 0;
            }
        }

        object ICollection.SyncRoot
        {
            get
            {
                return null;
            }
        }

        bool IList.IsFixedSize
        {
            get
            {
                return 0;
            }
        }

        bool IList.IsReadOnly
        {
            get
            {
                return 0;
            }
        }

        object IList.this[int index]
        {
            get
            {
                return null;
            }
            set
            {
            }
        }
    }
}

