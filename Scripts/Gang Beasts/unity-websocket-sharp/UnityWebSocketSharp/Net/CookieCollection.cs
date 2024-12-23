using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace UnityWebSocketSharp.Net
{
	[Serializable]
	[DefaultMember("Item")]
	internal class CookieCollection : ICollection<Cookie>, IEnumerable<Cookie>, IEnumerable
	{
		private List<Cookie> _list;

		private bool _readOnly;

		private object _sync;

		internal IEnumerable<Cookie> Sorted => null;

		public int Count => 0;

		public bool IsReadOnly => false;

		private void add(Cookie cookie)
		{
		}

		private static int compareForSorted(Cookie x, Cookie y)
		{
			return 0;
		}

		private static CookieCollection parseRequest(string value)
		{
			return null;
		}

		private static CookieCollection parseResponse(string value)
		{
			return null;
		}

		private int search(Cookie cookie)
		{
			return 0;
		}

		private static string urlDecode(string s, Encoding encoding)
		{
			return null;
		}

		internal static CookieCollection Parse(string value, bool response)
		{
			return null;
		}

		internal void SetOrRemove(Cookie cookie)
		{
		}

		internal void SetOrRemove(CookieCollection cookies)
		{
		}

		public void Add(Cookie cookie)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(Cookie cookie)
		{
			return false;
		}

		public void CopyTo(Cookie[] array, int index)
		{
		}

		public IEnumerator<Cookie> GetEnumerator()
		{
			return null;
		}

		public bool Remove(Cookie cookie)
		{
			return false;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
