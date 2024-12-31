using System;

namespace UnityEngine.Networking
{
	[Serializable]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public struct NetworkHash128
	{
		public byte i0;

		public byte i1;

		public byte i2;

		public byte i3;

		public byte i4;

		public byte i5;

		public byte i6;

		public byte i7;

		public byte i8;

		public byte i9;

		public byte i10;

		public byte i11;

		public byte i12;

		public byte i13;

		public byte i14;

		public byte i15;

		public void Reset()
		{
		}

		public bool IsValid()
		{
			return false;
		}

		private static int HexToNumber(char c)
		{
			return 0;
		}

		public static NetworkHash128 Parse(string text)
		{
			return default(NetworkHash128);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
