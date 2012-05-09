namespace System
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Security;

    public sealed class String : IEnumerable, IComparable, IComparable<string>, IEquatable<string>
    {
        public static readonly string Empty;

        [CLSCompliant(false), SecurityCritical]
        public unsafe String(char* value)
        {
            base..ctor();
            return;
        }

        [SecuritySafeCritical]
        public String(char[] value)
        {
            base..ctor();
            return;
        }

        [SecuritySafeCritical]
        public String(char c, int count)
        {
            base..ctor();
            return;
        }

        [SecurityCritical, CLSCompliant(false)]
        public unsafe String(char* value, int startIndex, int length)
        {
            base..ctor();
            return;
        }

        [SecuritySafeCritical]
        public String(char[] value, int startIndex, int length)
        {
            base..ctor();
            return;
        }

        public static int Compare(string strA, string strB)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static int Compare(string strA, string strB, StringComparison comparisonType)
        {
            return 0;
        }

        public static int Compare(string strA, int indexA, string strB, int indexB, int length)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
        {
            return 0;
        }

        public static int CompareOrdinal(string strA, string strB)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
        {
            return 0;
        }

        public int CompareTo(string strB)
        {
            return 0;
        }

        public static string Concat(IEnumerable<string> values)
        {
            return null;
        }

        public static string Concat(object arg0)
        {
            return null;
        }

        public static string Concat(params object[] args)
        {
            return null;
        }

        public static string Concat<T>(IEnumerable<T> values)
        {
            return null;
        }

        public static string Concat(params string[] values)
        {
            return null;
        }

        public static string Concat(object arg0, object arg1)
        {
            return null;
        }

        [SecuritySafeCritical]
        public static string Concat(string str0, string str1)
        {
            return null;
        }

        public static string Concat(object arg0, object arg1, object arg2)
        {
            return null;
        }

        [SecuritySafeCritical]
        public static string Concat(string str0, string str1, string str2)
        {
            return null;
        }

        [SecuritySafeCritical]
        public static string Concat(string str0, string str1, string str2, string str3)
        {
            return null;
        }

        public bool Contains(string value)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
        }

        public bool EndsWith(string value)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public bool EndsWith(string value, StringComparison comparisonType)
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return 0;
        }

        public bool Equals(string value)
        {
            return 0;
        }

        public static bool Equals(string a, string b)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public bool Equals(string value, StringComparison comparisonType)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public static bool Equals(string a, string b, StringComparison comparisonType)
        {
            return 0;
        }

        public static string Format(string format, params object[] args)
        {
            return null;
        }

        public static string Format(IFormatProvider provider, string format, params object[] args)
        {
            return null;
        }

        [SecuritySafeCritical]
        public override int GetHashCode()
        {
            return 0;
        }

        public int IndexOf(char value)
        {
            return 0;
        }

        public int IndexOf(string value)
        {
            return 0;
        }

        public int IndexOf(char value, int startIndex)
        {
            return 0;
        }

        public int IndexOf(string value, int startIndex)
        {
            return 0;
        }

        public int IndexOf(string value, StringComparison comparisonType)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public int IndexOf(char value, int startIndex, int count)
        {
            return 0;
        }

        public int IndexOf(string value, int startIndex, int count)
        {
            return 0;
        }

        public int IndexOf(string value, int startIndex, StringComparison comparisonType)
        {
            return 0;
        }

        public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
        {
            return 0;
        }

        public int IndexOfAny(char[] anyOf)
        {
            return 0;
        }

        public int IndexOfAny(char[] anyOf, int startIndex)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public int IndexOfAny(char[] anyOf, int startIndex, int count)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public string Insert(int startIndex, string value)
        {
            return null;
        }

        public static bool IsNullOrEmpty(string value)
        {
            return 0;
        }

        public static bool IsNullOrWhiteSpace(string value)
        {
            return 0;
        }

        public static string Join(string separator, IEnumerable<string> values)
        {
            return null;
        }

        public static string Join(string separator, params object[] values)
        {
            return null;
        }

        public static string Join(string separator, params string[] value)
        {
            return null;
        }

        public static string Join<T>(string separator, IEnumerable<T> values)
        {
            return null;
        }

        [SecuritySafeCritical]
        public static string Join(string separator, string[] value, int startIndex, int count)
        {
            return null;
        }

        public int LastIndexOf(char value)
        {
            return 0;
        }

        public int LastIndexOf(string value)
        {
            return 0;
        }

        public int LastIndexOf(char value, int startIndex)
        {
            return 0;
        }

        public int LastIndexOf(string value, int startIndex)
        {
            return 0;
        }

        public int LastIndexOf(string value, StringComparison comparisonType)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public int LastIndexOf(char value, int startIndex, int count)
        {
            return 0;
        }

        public int LastIndexOf(string value, int startIndex, int count)
        {
            return 0;
        }

        public int LastIndexOf(string value, int startIndex, StringComparison comparisonType)
        {
            return 0;
        }

        public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
        {
            return 0;
        }

        public int LastIndexOfAny(char[] anyOf)
        {
            return 0;
        }

        public int LastIndexOfAny(char[] anyOf, int startIndex)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
        {
            return 0;
        }

        public static bool operator ==(string a, string b)
        {
            return 0;
        }

        public static bool operator !=(string a, string b)
        {
            return 0;
        }

        public string PadLeft(int totalWidth)
        {
            return null;
        }

        public string PadLeft(int totalWidth, char paddingChar)
        {
            return null;
        }

        public string PadRight(int totalWidth)
        {
            return null;
        }

        public string PadRight(int totalWidth, char paddingChar)
        {
            return null;
        }

        public string Remove(int startIndex)
        {
            return null;
        }

        [SecuritySafeCritical]
        public string Remove(int startIndex, int count)
        {
            return null;
        }

        public string Replace(char oldChar, char newChar)
        {
            return null;
        }

        public string Replace(string oldValue, string newValue)
        {
            return null;
        }

        public string[] Split(params char[] separator)
        {
            return null;
        }

        public string[] Split(char[] separator, int count)
        {
            return null;
        }

        public string[] Split(char[] separator, StringSplitOptions options)
        {
            return null;
        }

        public string[] Split(string[] separator, StringSplitOptions options)
        {
            return null;
        }

        public string[] Split(char[] separator, int count, StringSplitOptions options)
        {
            return null;
        }

        public string[] Split(string[] separator, int count, StringSplitOptions options)
        {
            return null;
        }

        public bool StartsWith(string value)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public bool StartsWith(string value, StringComparison comparisonType)
        {
            return 0;
        }

        public string Substring(int startIndex)
        {
            return null;
        }

        [SecuritySafeCritical]
        public string Substring(int startIndex, int length)
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }

        int IComparable.CompareTo(object value)
        {
            return 0;
        }

        [SecuritySafeCritical]
        public char[] ToCharArray()
        {
            return null;
        }

        [SecuritySafeCritical]
        public char[] ToCharArray(int startIndex, int length)
        {
            return null;
        }

        public string ToLower()
        {
            return null;
        }

        public string ToLowerInvariant()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public string ToUpper()
        {
            return null;
        }

        public string ToUpperInvariant()
        {
            return null;
        }

        public string Trim()
        {
            return null;
        }

        public string Trim(params char[] trimChars)
        {
            return null;
        }

        public string TrimEnd(params char[] trimChars)
        {
            return null;
        }

        public string TrimStart(params char[] trimChars)
        {
            return null;
        }

        public char this[int index]
        {
            [SecuritySafeCritical]
            get
            {
                return 0;
            }
        }

        public int Length
        {
            [SecuritySafeCritical]
            get
            {
                return 0;
            }
        }
    }
}

