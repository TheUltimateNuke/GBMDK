using System;

namespace CoreNet.Utils
{
	public class SpawnParam<T> : ISpawnParam
	{
		private string _paramName;

		private T _paramValue;

		public string GetParamName()
		{
			return null;
		}

		public object GetParamValue()
		{
			return null;
		}

		public Type GetParamType()
		{
			return null;
		}

		public SpawnParam(string name, T value)
		{
		}
	}
}
