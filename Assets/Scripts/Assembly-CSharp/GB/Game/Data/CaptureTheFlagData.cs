using GB.Data.Loading;
using UnityEngine;

namespace GB.Game.Data
{
	[CreateAssetMenu(fileName = "CaptureTheFlagData", menuName = "Gang Beasts/Data/Game/Capture The Flag Data", order = 1)]
	public class CaptureTheFlagData : ScriptableObject, IDataRegister
	{
		[SerializeField]
		private GameObject _flagObject;

		[SerializeField]
		private int _flagCount;

		public GameObject Flag => null;

		public int FlagCount => 0;

		public void Register()
		{
		}

		public void Unregister()
		{
		}
	}
}
