using Costumes;
using Femur;
using GB.Data;
using GB.Platform.Lobby;
using UnityEngine;

namespace GB.UI.Beasts
{
	public class BeastMenuState : MonoBehaviour
	{
		private class PointState
		{
			private BeastMenuState _parent;

			private Actor _beast;

			private bool _handsRaised;

			private bool _teamOverride;

			private ColorCache _colourCache;

			private ColorCache _colourTeamCache;

			private CostumeSaveEntry _costumeCache;

			public int AvailableTeams;

			private LocalPlayerInfomationCache _linkedLocal;

			private OnlinePlayerInfomationCache _linkedOnline;

			public bool TeamOverride
			{
				set
				{
				}
			}

			public Actor Beast
			{
				set
				{
				}
			}

			public bool HandsRaised
			{
				set
				{
				}
			}

			public ColorCache Colour
			{
				set
				{
				}
			}

			public ColorCache TeamColour
			{
				set
				{
				}
			}

			public CostumeSaveEntry Costume
			{
				set
				{
				}
			}

			public PointState(BeastMenuState parent)
			{
			}

			public void SetLink(LocalPlayerInfomationCache newLink)
			{
			}

			public void SetLink(OnlinePlayerInfomationCache newLink)
			{
			}

			private void OnlineStateChange(OnlinePlayerInfomationCache arg1, BeastUtils.PlayerState arg2)
			{
			}

			private void OnlineVoiceChange(OnlinePlayerInfomationCache arg1, Actor.Voice arg2)
			{
			}

			private void OnlineTeamChange(OnlinePlayerInfomationCache arg1, int arg2)
			{
			}

			private void OnlineCostumeChange(OnlinePlayerInfomationCache obj)
			{
			}

			private void OnlineColourChange(OnlinePlayerInfomationCache obj)
			{
			}

			public void ClearLinks(bool updateDraw)
			{
			}

			private void LocalChangeState(LocalPlayerInfomationCache playerID, BeastUtils.PlayerState oldValue, BeastUtils.PlayerState newValue)
			{
			}

			private void LocalChangeColour(LocalPlayerInfomationCache playerID, int oldValue, int newValue)
			{
			}

			private void LocalChangeCostume(LocalPlayerInfomationCache playerID, int oldValue, int newValue)
			{
			}

			private void LocalChangeTeam(LocalPlayerInfomationCache playerID, int oldValue, int newValue)
			{
			}

			public void UpdateTeamColour()
			{
			}

			private void UpdateBeast()
			{
			}

			private void SetShowBeast()
			{
			}

			private void SetHands()
			{
			}

			private void SetColour()
			{
			}

			private void SetCostumeSeq()
			{
			}

			public void ResetCostume()
			{
			}

			~PointState()
			{
			}
		}

		[SerializeField]
		private BeastMenuSpawner _beastSpawnPoints;

		[SerializeField]
		private BeastMenuManager _beastManager;

		private PointState[] _pointStates;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void AssignCoroutine(PointState point, Coroutine routine)
		{
		}

		private void _beastManager_OnShowTeams()
		{
		}

		private void __beastSpawnPoints_OnBeastGenerated(int point, Actor beast)
		{
		}

		private void _beastManager_OnPositionPlayerChanged(int point, int player)
		{
		}
	}
}
