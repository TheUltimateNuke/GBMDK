using UnityEngine;

namespace GB.Game.Data
{
	[CreateAssetMenu(fileName = "FootballData", menuName = "Gang Beasts/Data/Game/Football Data", order = 1)]
	public class FootballData : ScriptableObject
	{
		[SerializeField]
		private GameObject _footballObject;

		public GameObject Football => null;
	}
}
