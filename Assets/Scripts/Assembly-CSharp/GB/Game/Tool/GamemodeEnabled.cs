using CoreNet.Objects;
using GB.Gamemodes;
using GB.Utils;
using UnityEngine;

namespace GB.Game.Tool
{
	public class GamemodeEnabled : MonoBehaviour
	{
		[SerializeField]
		private bool _enableItems;

		[EnumUtils.EnumFlags]
		[SerializeField]
		private GameModeEnum _neededMode;

		[SerializeField]
		private GameObject[] _bothSides;

		[SerializeField]
		private GameObject[] _serverSide;

		[SerializeField]
		private GameObject[] _clientSide;

		[SerializeField]
		private GameObject[] _clientLocalSide;

		[SerializeField]
		private GameObject[] _clientOnlineSide;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnModeChange(NetString newMode)
		{
		}
	}
}
