using GB.Data.Loading;
using UnityEngine;

namespace GB.Game.Data
{
	[CreateAssetMenu(fileName = "KingOfTheHillData", menuName = "Gang Beasts/Data/Game/King of the Hill Data", order = 1)]
	public class KingOfTheHillData : ScriptableObject, IDataRegister
	{
		[SerializeField]
		private GameObject _hillObject;

		public GameObject Hill => null;

		public void Register()
		{
		}

		public void Unregister()
		{
		}
	}
}
