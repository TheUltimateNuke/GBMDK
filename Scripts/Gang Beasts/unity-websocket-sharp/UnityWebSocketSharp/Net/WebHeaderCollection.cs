using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace UnityWebSocketSharp.Net
{
	[Serializable]
	[DefaultMember("Item")]
	[ComVisible(true)]
	internal class WebHeaderCollection : NameValueCollection, ISerializable
	{
		private static readonly Dictionary<string, HttpHeaderInfo> _headers;

		private bool _internallyUsed;

		private HttpHeaderType _state;

		public override string[] AllKeys => null;

		public override int Count => 0;

		public override KeysCollection Keys => null;

		static WebHeaderCollection()
		{
		}

		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public WebHeaderCollection()
		{
		}

		private void add(string name, string value, HttpHeaderType headerType)
		{
		}

		private void checkAllowed(HttpHeaderType headerType)
		{
		}

		private static string checkName(string name, string paramName)
		{
			return null;
		}

		private void checkRestricted(string name, HttpHeaderType headerType)
		{
		}

		private static string checkValue(string value, string paramName)
		{
			return null;
		}

		private static HttpHeaderInfo getHeaderInfo(string name)
		{
			return null;
		}

		private static HttpHeaderType getHeaderType(string name)
		{
			return default(HttpHeaderType);
		}

		private static bool isMultiValue(string name, bool response)
		{
			return false;
		}

		private static bool isRestricted(string name, bool response)
		{
			return false;
		}

		private void set(string name, string value, HttpHeaderType headerType)
		{
		}

		internal void InternalSet(string header, bool response)
		{
		}

		public override void Add(string name, string value)
		{
		}

		public override void Clear()
		{
		}

		public override string Get(int index)
		{
			return null;
		}

		public override string Get(string name)
		{
			return null;
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public override string GetKey(int index)
		{
			return null;
		}

		public override string[] GetValues(int index)
		{
			return null;
		}

		public override string[] GetValues(string name)
		{
			return null;
		}

		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public override void OnDeserialization(object sender)
		{
		}

		public override void Remove(string name)
		{
		}

		public override void Set(string name, string value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void System_002ERuntime_002ESerialization_002EISerializable_002EGetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
