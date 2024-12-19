using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityWebSocketSharp.Net;

namespace UnityWebSocketSharp
{
	internal static class Ext
	{
		[CompilerGenerated]
		private sealed class _003CSplitHeaderValue_003Ed__54 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private string value;

			public string _003C_003E3__value;

			private char[] separators;

			public char[] _003C_003E3__separators;

			private int _003Cend_003E5__2;

			private StringBuilder _003Cbuff_003E5__3;

			private bool _003Cescaped_003E5__4;

			private bool _003Cquoted_003E5__5;

			private int _003Ci_003E5__6;

			private string System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EString_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public string Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CSplitHeaderValue_003Ed__54(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<string> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EString_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

            public IEnumerator<string> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		private static readonly byte[] _last;

		private static readonly int _maxRetry;

		private static MemoryStream compress(this Stream stream)
		{
			return null;
		}

		private static byte[] decompress(this byte[] data)
		{
			return null;
		}

		private static MemoryStream decompress(this Stream stream)
		{
			return null;
		}

		private static byte[] decompressToArray(this Stream stream)
		{
			return null;
		}

		private static bool isPredefinedScheme(this string value)
		{
			return false;
		}

		internal static byte[] Append(this ushort code, string reason)
		{
			return null;
		}

		internal static Stream Compress(this Stream stream, CompressionMethod method)
		{
			return null;
		}

		internal static bool Contains(this string value, params char[] anyOf)
		{
			return false;
		}

		internal static bool Contains(this NameValueCollection collection, string name, string value, StringComparison comparisonTypeForValue)
		{
			return false;
		}

		internal static bool Contains<T>(this IEnumerable<T> source, Func<T, bool> condition)
		{
			return false;
		}

		internal static bool ContainsTwice(this string[] values)
		{
			return false;
		}

		internal static byte[] Decompress(this byte[] data, CompressionMethod method)
		{
			return null;
		}

		internal static byte[] DecompressToArray(this Stream stream, CompressionMethod method)
		{
			return null;
		}

		internal static void Emit(this EventHandler eventHandler, object sender, EventArgs e)
		{
		}

		internal static void Emit<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e) where TEventArgs : EventArgs
		{
		}

		internal static string GetAbsolutePath(this Uri uri)
		{
			return null;
		}

		internal static CookieCollection GetCookies(this NameValueCollection headers, bool response)
		{
			return null;
		}

		internal static string GetErrorMessage(this ushort code)
		{
			return null;
		}

		internal static byte[] GetUTF8EncodedBytes(this string s)
		{
			return null;
		}

		internal static string GetValue(this string nameAndValue, char separator, bool unquote)
		{
			return null;
		}

		internal static bool IsCompressionExtension(this string value, CompressionMethod method)
		{
			return false;
		}

		internal static bool IsEqualTo(this int value, char c, Action<int> beforeComparing)
		{
			return false;
		}

		internal static bool IsReservedStatusCode(this ushort code)
		{
			return false;
		}

		internal static bool IsSupportedOpcode(this byte opcode)
		{
			return false;
		}

		internal static bool IsText(this string value)
		{
			return false;
		}

		internal static bool IsToken(this string value)
		{
			return false;
		}

		internal static bool MaybeUri(this string value)
		{
			return false;
		}

		internal static byte[] ReadBytes(this Stream stream, int length)
		{
			return null;
		}

		internal static byte[] ReadBytes(this Stream stream, long length, int bufferLength)
		{
			return null;
		}

		internal static void ReadBytesAsync(this Stream stream, int length, Action<byte[]> completed, Action<Exception> error)
		{
		}

		internal static void ReadBytesAsync(this Stream stream, long length, int bufferLength, Action<byte[]> completed, Action<Exception> error)
		{
		}

		internal static T[] Reverse<T>(this T[] array)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSplitHeaderValue_003Ed__54))]
		internal static IEnumerable<string> SplitHeaderValue(this string value, params char[] separators)
		{
			return null;
		}

		internal static byte[] ToByteArray(this Stream stream)
		{
			return null;
		}

		internal static byte[] ToByteArray(this ushort value, ByteOrder order)
		{
			return null;
		}

		internal static byte[] ToByteArray(this ulong value, ByteOrder order)
		{
			return null;
		}

		internal static string ToExtensionString(this CompressionMethod method, params string[] parameters)
		{
			return null;
		}

		internal static int ToInt32(this string numericString)
		{
			return 0;
		}

		internal static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		internal static ushort ToUInt16(this byte[] source, ByteOrder sourceOrder)
		{
			return 0;
		}

		internal static ulong ToUInt64(this byte[] source, ByteOrder sourceOrder)
		{
			return 0uL;
		}

		internal static Version ToVersion(this string versionString)
		{
			return null;
		}

		internal static bool TryCreateWebSocketUri(this string uriString, out Uri result, out string message)
		{
			result = null;
			message = null;
			return false;
		}

		internal static bool TryGetUTF8DecodedString(this byte[] bytes, out string s)
		{
			s = null;
			return false;
		}

		internal static bool TryGetUTF8EncodedBytes(this string s, out byte[] bytes)
		{
			bytes = null;
			return false;
		}

		internal static string Unquote(this string value)
		{
			return null;
		}

		internal static bool Upgrades(this NameValueCollection headers, string protocol)
		{
			return false;
		}

		internal static void WriteBytes(this Stream stream, byte[] bytes, int bufferLength)
		{
		}

		public static bool IsCloseStatusCode(this ushort value)
		{
			return false;
		}

		public static bool IsEnclosedIn(this string value, char c)
		{
			return false;
		}

		public static bool IsHostOrder(this ByteOrder order)
		{
			return false;
		}

		public static bool IsNullOrEmpty(this string value)
		{
			return false;
		}

		public static T[] SubArray<T>(this T[] array, int startIndex, int length)
		{
			return null;
		}

		public static T[] SubArray<T>(this T[] array, long startIndex, long length)
		{
			return null;
		}

		public static byte[] ToHostOrder(this byte[] source, ByteOrder sourceOrder)
		{
			return null;
		}

		public static string ToString<T>(this T[] array, string separator)
		{
			return null;
		}

		public static Uri ToUri(this string value)
		{
			return null;
		}
	}
}
