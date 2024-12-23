using System;
using System.Collections.Specialized;
using System.IO;

namespace UnityWebSocketSharp
{
	internal abstract class HttpBase
	{
		private NameValueCollection _headers;

		private static readonly int _maxMessageHeaderLength;

		private string _messageBody;

		private byte[] _messageBodyData;

		private Version _version;

		protected static readonly string CrLf;

		protected static readonly string CrLfHt;

		protected static readonly string CrLfSp;

		protected string HeaderSection => null;

		public NameValueCollection Headers => null;

		public string MessageBody => null;

		public abstract string MessageHeader { get; }

		public Version ProtocolVersion => null;

		static HttpBase()
		{
		}

		protected HttpBase(Version version, NameValueCollection headers)
		{
		}

		private string getMessageBody()
		{
			return null;
		}

		private static byte[] readMessageBodyFrom(Stream stream, string length)
		{
			return null;
		}

		private static string[] readMessageHeaderFrom(Stream stream)
		{
			return null;
		}

		internal void WriteTo(Stream stream)
		{
		}

		protected static T Read<T>(Stream stream, Func<string[], T> parser, int millisecondsTimeout) where T : HttpBase
		{
			return null;
		}

		public byte[] ToByteArray()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
