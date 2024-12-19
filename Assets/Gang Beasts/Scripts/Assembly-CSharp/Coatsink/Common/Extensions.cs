using System;
using System.IO;

namespace Coatsink.Common
{
	public static class Extensions
	{
		public static bool TryWrite(this BinaryWriter writer, TypeCode code, primitive pr)
		{
			return false;
		}

		public static bool TryRead(this BinaryReader reader, TypeCode code, ref primitive pr)
		{
			return false;
		}
	}
}
