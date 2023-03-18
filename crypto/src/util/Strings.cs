using System;
using System.Text;

namespace Org.BouncyCastle.Utilities
{
    /// <summary> General string utilities.</summary>
    public static class Strings
    {
        private static readonly UTF8Encoding utf8NoBomThrowInvalid =
            new (encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        internal static bool IsOneOf(string s, params string[] candidates)
        {
            foreach (string candidate in candidates)
            {
                if (s == candidate)
                    return true;
            }
            return false;
        }

        public static string FromByteArray(byte[] bs)
        {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return string.Create(bs.Length, bs, (chars, bytes) =>
            {
                for (int i = 0; i < chars.Length; ++i)
                {
                    chars[i] = Convert.ToChar(bytes[i]);
                }
            });
#else
            char[] cs = new char[bs.Length];
            for (int i = 0; i < cs.Length; ++i)
            {
                cs[i] = Convert.ToChar(bs[i]);
            }
            return new string(cs);
#endif
        }

        public static byte[] ToByteArray(char[] cs)
        {
            byte[] bs = new byte[cs.Length];
            for (int i = 0; i < bs.Length; ++i)
            {
                bs[i] = Convert.ToByte(cs[i]);
            }
            return bs;
        }

        public static byte[] ToByteArray(string s)
        {
            byte[] bs = new byte[s.Length];
            for (int i = 0; i < bs.Length; ++i)
            {
                bs[i] = Convert.ToByte(s[i]);
            }
            return bs;
        }

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        public static byte[] ToByteArray(ReadOnlySpan<char> cs)
        {
            byte[] bs = new byte[cs.Length];
            for (int i = 0; i < bs.Length; ++i)
            {
                bs[i] = Convert.ToByte(cs[i]);
            }
            return bs;
        }
#endif

        public static string FromAsciiByteArray(byte[] bytes)
        {
            return Encoding.ASCII.GetString(bytes);
        }

        public static byte[] ToAsciiByteArray(char[] cs)
        {
            return Encoding.ASCII.GetBytes(cs);
        }

        public static byte[] ToAsciiByteArray(string s)
        {
            return Encoding.ASCII.GetBytes(s);
        }

        public static string FromUtf8ByteArray(byte[] bytes)
        {
            return Strings.FromUtf8ByteArray(bytes, 0, bytes.Length);
        }

        public static string FromUtf8ByteArray(byte[] bytes, int index, int count)
        {
            return utf8NoBomThrowInvalid.GetString(bytes, index, count);
        }

        public static byte[] ToUtf8ByteArray(char[] cs)
        {
            return utf8NoBomThrowInvalid.GetBytes(cs);
        }

        public static byte[] ToUtf8ByteArray(string s)
        {
            return utf8NoBomThrowInvalid.GetBytes(s);
        }

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        public static byte[] ToUtf8ByteArray(ReadOnlySpan<char> cs)
        {
            int count = utf8NoBomThrowInvalid.GetByteCount(cs);
            byte[] bytes = new byte[count];
            utf8NoBomThrowInvalid.GetBytes(cs, bytes);
            return bytes;
        }
#endif
    }
}
