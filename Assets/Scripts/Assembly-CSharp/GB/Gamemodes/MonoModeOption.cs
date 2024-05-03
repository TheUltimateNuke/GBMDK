using UnityEngine;

namespace GB.Gamemodes
{
	public abstract class MonoModeOption<T> : MonoBehaviour
	{
		public abstract string GetOptionName();

		public abstract T GetOptionValue();
	}
}
