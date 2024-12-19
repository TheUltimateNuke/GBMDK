using System;
using GB.UI.Beasts;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GB.Platform.Lobby
{
	public class BeastBasedSelection : MonoBehaviour, ISelectHandler, IEventSystemHandler, IMoveHandler, IDeselectHandler, ISubmitHandler
	{
		[Serializable]
		private struct OrderCarrier
		{
			public int spawnID;

			public NamebarHandler nameBar;

			public OrderCarrier(int _id, NamebarHandler _nameBar)
			{
				spawnID = 0;
				nameBar = null;
			}
		}

		[SerializeField]
		private OrderCarrier[] _spawnOrders;

		[SerializeField]
		private BeastMenuManager _beastOwners;

		private bool _selected;

		private int _selectingSpawn;

		private int _lastSelectedPlayerID;

		private Camera _cameraRef;

		[SerializeField]
		private float _startRange;

		[SerializeField]
		private Selectable _selectable;

		[SerializeField]
		private string _onClickInputCode;

		[SerializeField]
		private string _kickInputCode;

		[SerializeField]
		private string _kickTextCode;

		[SerializeField]
		private bool _showKick;

		[SerializeField]
		private string _muteInputCode;

		[SerializeField]
		private string _muteTextCode;

		[SerializeField]
		private bool _showMute;

		private Vector2 _lastMouse;

		public int Selection
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		public void KickSelected()
		{
		}

		public void MuteSelected()
		{
		}

		public void InfoSelected()
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		private void _beastOwners_OnPositionPlayerChanged(int point, int player)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		private void UpdateSelectionVisuals()
		{
		}

		private void UpdateUI()
		{
		}

		public void OnMove(AxisEventData eventData)
		{
		}

		public void ReselectLast()
		{
		}

		private void Update()
		{
		}

		private void CheckMouseOver()
		{
		}

		private void OnClickCheck()
		{
		}

		private void CheckButtonPresses()
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}
	}
}
