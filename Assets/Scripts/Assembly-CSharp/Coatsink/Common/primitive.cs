using System;
using System.Runtime.InteropServices;

namespace Coatsink.Common
{
	[StructLayout(2)]
	public struct primitive
	{
		public bool bl;

		public char ch;

		public byte u1;

		public ushort u2;

		public uint u4;

		public ulong u8;

		public sbyte s1;

		public short s2;

		public int s4;

		public long s8;

		public float f4;

		public double f8;

		public bool b_0;

		public bool b_1;

		public bool b_2;

		public bool b_3;

		public bool b_4;

		public bool b_5;

		public bool b_6;

		public bool b_7;

		public byte u1_0;

		public byte u1_1;

		public byte u1_2;

		public byte u1_3;

		public byte u1_4;

		public byte u1_5;

		public byte u1_6;

		public byte u1_7;

		public int s4_0;

		public int s4_1;

		public void Set(object obj, TypeCode code)
		{
		}

		public TypeCode Set(object obj)
		{
			return default(TypeCode);
		}

		public TypeCode TrySet(object obj)
		{
			return default(TypeCode);
		}

		public string ToString(TypeCode code, string format = null)
		{
			return null;
		}

		public object Get(TypeCode code)
		{
			return null;
		}
	}
}
