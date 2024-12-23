using System;

namespace Coatsink.Common
{
	public static class Wrapper
	{
		public static Wrapper<T> AroundA<T>() where T : class
		{
			return null;
		}

		public static Wrapper<T> Around<T>(T valIn)
		{
			return null;
		}
	}
	[Serializable]
	public class Wrapper<T>
	{
		public T val;

		public Wrapper(T valIn)
		{
		}

		public static explicit operator T(Wrapper<T> wrapper)
		{
			return default(T);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
