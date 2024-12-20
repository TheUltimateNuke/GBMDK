using GB.Data.Loading;
using UnityEngine;

namespace GB.Game.Data
{
	[CreateAssetMenu(fileName = "FootballData", menuName = "Gang Beasts/Data/Game/Football Data", order = 1)]
	public class FootballData : ScriptableObject, IDataRegister
	{
		[SerializeField]
		private GameObject _footballObject;

		public GameObject Football => null;

		public void Register()
		{
		}

		public void Unregister()
		{
		}
	}
}
