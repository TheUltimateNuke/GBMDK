using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CS.CorePlatform;
using GB.Networking.Objects;
using UnityEngine;

namespace GB.UI
{
	public class PlayerList : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CReorder_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerList _003C_003E4__this;

			public bool foundSelection;

			public GameObject select;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CReorder_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[SerializeField]
		private Transform _teamParent;

		[SerializeField]
		private GameObject _buttonBase;

		[SerializeField]
		private GameObject _teamBase;

		[SerializeField]
		private Color _defaultColour;

		[SerializeField]
		private RectTransform _rebuildTarget;

		[SerializeField]
		private LocalisedText _voipSetting;

		[SerializeField]
		private string _onCode;

		[SerializeField]
		private string _offCode;

		private List<PlayerListButton> _activeButtons;

		private Dictionary<int, Transform> _activeTeams;

		private List<PlayerListButton> _activeButtonsAI;

		private void OnEnable()
		{
		}

		private void OnPlatformChanged(NetPlatform item)
		{
		}

		private void OnGangChanged(NetGang item)
		{
		}

		private void OnDisable()
		{
		}

		private void OnChatChanged(NetChat item)
		{
		}

		private void RefreshUI()
		{
		}

		[IteratorStateMachine(typeof(_003CReorder_003Ed__17))]
		private IEnumerator Reorder(bool foundSelection, GameObject select)
		{
			return null;
		}

		private Transform GetGangObject(int gangID)
		{
			return null;
		}

		private PlayerListButton GetPlayer(BaseUserInfo user, int controller)
		{
			return null;
		}

		private PlayerListButton GetAI(int counter)
		{
			return null;
		}
	}
}
