using System;

namespace WebSocketSharp.Net
{
	[Serializable]
	public sealed class Cookie
	{
		private string _comment;

		private Uri _commentUri;

		private bool _discard;

		private string _domain;

		private static readonly int[] _emptyPorts;

		private DateTime _expires;

		private bool _httpOnly;

		private string _name;

		private string _path;

		private string _port;

		private int[] _ports;

		private static readonly char[] _reservedCharsForValue;

		private string _sameSite;

		private bool _secure;

		private DateTime _timeStamp;

		private string _value;

		private int _version;

		internal int MaxAge
		{
			set
			{
			}
		}

		internal string SameSite
		{
			set
			{
			}
		}

		internal string Comment
		{
			set
			{
			}
		}

		internal Uri CommentUri
		{
			set
			{
			}
		}

		internal bool Discard
		{
			set
			{
			}
		}

		public string Domain
		{
			set
			{
			}
		}

		public bool Expired => false;

		public DateTime Expires
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public bool HttpOnly
		{
			set
			{
			}
		}

		public string Name => null;

		public string Path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string Port
		{
			set
			{
			}
		}

		public bool Secure
		{
			set
			{
			}
		}

		public int Version
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		static Cookie()
		{
		}

		internal Cookie()
		{
		}

		public Cookie(string name, string value)
		{
		}

		public Cookie(string name, string value, string path, string domain)
		{
		}

		private static int hash(int i, int j, int k, int l, int m)
		{
			return 0;
		}

		private void init(string name, string value, string path, string domain)
		{
		}

		private static bool tryCreatePorts(string value, out int[] result)
		{
			result = null;
			return false;
		}

		internal bool EqualsWithoutValue(Cookie cookie)
		{
			return false;
		}

		internal string ToRequestString(Uri uri)
		{
			return null;
		}

		internal static bool TryCreate(string name, string value, out Cookie result)
		{
			result = null;
			return false;
		}

		public override bool Equals(object comparand)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
