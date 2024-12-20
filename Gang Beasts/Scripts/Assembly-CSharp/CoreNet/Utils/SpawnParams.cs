using System.Collections.Generic;

namespace CoreNet.Utils
{
	public class SpawnParams
	{
		private List<ISpawnParam> heldParams;

		public bool AddParam(ISpawnParam param)
		{
			return false;
		}

		public bool CheckParamExists(string paramName)
		{
			return false;
		}

		public ISpawnParam GetParam(string paramName)
		{
			return null;
		}

		public bool GetParam<T>(string paramName, out T result, T defaultvalue)
		{
			result = default(T);
			return false;
		}

		public bool RemoveParam(string paramName)
		{
			return false;
		}

		public void ChangeParam<T>(string paramName, T value)
		{
		}

		public SpawnParams Copy()
		{
			return null;
		}
	}
}
