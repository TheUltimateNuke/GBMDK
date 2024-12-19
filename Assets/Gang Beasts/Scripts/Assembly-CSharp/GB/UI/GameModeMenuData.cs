using UnityEngine;

namespace GB.UI
{
	[CreateAssetMenu(fileName = "GameModeData", menuName = "ScriptableObjects/GameModeMenuData", order = 1)]
	public class GameModeMenuData : ScriptableObject
	{
		public GameModeData[] GameModes;
	}
}
