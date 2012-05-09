namespace System
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Char : IComparable, IComparable<char>, IEquatable<char>
    {
        public const char MaxValue = '￿';
        public const char MinValue = '\0';
        public int CompareTo(char value)
        {
            return 0;
        }

        public static string ConvertFromUtf32(int utf32)
        {
            return null;
        }

        public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
        {
            return 0;
        }

        public static int ConvertToUtf32(string s, int index)
        {
            return 0;
        }

        public bool Equals(char obj)
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return 0;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static double GetNumericValue(char c)
        {
            return 0.0;
        }

        public static double GetNumericValue(string s, int index)
        {
            return 0.0;
        }

        public static bool IsControl(char c)
        {
            return 0;
        }

        public static bool IsControl(string s, int index)
        {
            return 0;
        }

        public static bool IsDigit(char c)
        {
            return 0;
        }

        public static bool IsDigit(string s, int index)
        {
            return 0;
        }

        public static bool IsHighSurrogate(char c)
        {
            return 0;
        }

        public static bool IsHighSurrogate(string s, int index)
        {
            return 0;
        }

        public static bool IsLetter(char c)
        {
            return 0;
        }

        public static bool IsLetter(string s, int index)
        {
            return 0;
        }

        public static bool IsLetterOrDigit(char c)
        {
            return 0;
        }

        public static bool IsLetterOrDigit(string s, int index)
        {
            return 0;
        }

        public static bool IsLower(char c)
        {
            return 0;
        }

        public static bool IsLower(string s, int index)
        {
            return 0;
        }

        public static bool IsLowSurrogate(char c)
        {
            return 0;
        }

        public static bool IsLowSurrogate(string s, int index)
        {
            return 0;
        }

        public static bool IsNumber(char c)
        {
            return 0;
        }

        public static bool IsNumber(string s, int index)
        {
            return 0;
        }

        public static bool IsPunctuation(char c)
        {
            return 0;
        }

        public static bool IsPunctuation(string s, int index)
        {
            return 0;
        }

        public static bool IsSeparator(char c)
        {
            return 0;
        }

        public static bool IsSeparator(string s, int index)
        {
            return 0;
        }

        public static bool IsSurrogate(char c)
        {
            return 0;
        }

        public static bool IsSurrogate(string s, int index)
        {
            return 0;
        }

        public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
        {
            return 0;
        }

        public static bool IsSurrogatePair(string s, int index)
        {
            return 0;
        }

        public static bool IsSymbol(char c)
        {
            return 0;
        }

        public static bool IsSymbol(string s, int index)
        {
            return 0;
        }

        public static bool IsUpper(char c)
        {
            return 0;
        }

        public static bool IsUpper(string s, int index)
        {
            return 0;
        }

        public static bool IsWhiteSpace(char c)
        {
            return 0;
        }

        public static bool IsWhiteSpace(string s, int index)
        {
            return 0;
        }

        int IComparable.CompareTo(object value)
        {
            return 0;
        }

        public static char ToLower(char c)
        {
            return 0;
        }

        public static char ToLowerInvariant(char c)
        {
            return 0;
        }

        public override string ToString()
        {
            return null;
        }

        public static string ToString(char c)
        {
            return null;
        }

        public static char ToUpper(char c)
        {
            return 0;
        }

        public static char ToUpperInvariant(char c)
        {
            return 0;
        }

        public static unsafe bool TryParse(string s, out char result)
        {
            *((short*) result) = 0;
            return 0;
        }
    }
}

