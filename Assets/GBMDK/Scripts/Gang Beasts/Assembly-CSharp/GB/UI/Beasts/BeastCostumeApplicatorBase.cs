using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Platform.Lobby;
using GB.UI.Menu;
using UnityEngine;

namespace GB.UI.Beasts
{
	public class BeastCostumeApplicatorBase : MonoBehaviour
	{
		[Serializable]
		protected struct InputMap
		{
			public enum ButtonStyle
			{
				button = 0,
				axis_pos = 1,
				axis_neg = 2,
				none = 3
			}

			public string code;

			public ButtonStyle style;

			public InputMap(string ncode, ButtonStyle nstyle)
			{
				code = null;
				style = default(ButtonStyle);
			}
		}

		[CompilerGenerated]
		private sealed class _003CApplyStay_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BeastCostumeApplicatorBase _003C_003E4__this;

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

			object IEnumerator<object>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CApplyStay_003Ed__47(int _003C_003E1__state)
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
				return MoveNext();
			}

			void IEnumerator.Reset()
			{
				throw new NotImplementedException();
			}

			void IDisposable.Dispose()
			{
				throw new NotImplementedException();
			}
		}

		protected LocalBeastSetupTracker _beastInfoTracker;

		[SerializeField]
		protected float _changeCooldownTimer;

		protected float[] _changeColourDelay;

		protected float[] _changeCostumeDelay;

		private LobbyState.State prevLobbyState;

		[SerializeField]
		protected InputMap _costumeNext;

		[SerializeField]
		protected InputMap _costumePrev;

		[SerializeField]
		protected InputMap _colourNext;

		[SerializeField]
		protected InputMap _colourPrev;

		[SerializeField]
		protected GameObject _blockingObject;

		[SerializeField]
		protected BeastMenuManager _beastManager;

		[SerializeField]
		protected MenuController _MC;

		[SerializeField]
		protected BaseMenuScreen _ExitPrompt;

		[SerializeField]
		protected UIPlayerInputManager _MyUIPlayerInputManager;

		protected BaseMenuScreen _m_MenuScreen;

		private Action readyAction;

		private Action cancelAction;

		[SerializeField]
		private bool _blockEditing;

		[SerializeField]
		private bool _listenForTeam;

		private bool _skipNextFrame;

		private bool _lastAllowStateUpdate;

		public bool AllowStateUpdate => false;

		private void Start()
		{
		}

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		private void Update()
		{
		}

		protected bool PlayerCheck(int i, ref int inactiveOne)
		{
			return false;
		}

		protected virtual void applySubmit()
		{
		}

		protected virtual void applyCancel()
		{
		}

		protected virtual bool OnInactive(LocalPlayerInfomationCache player)
		{
			return false;
		}

		protected virtual bool OnDesigning(LocalPlayerInfomationCache player)
		{
			return false;
		}

		protected virtual bool OnReady(LocalPlayerInfomationCache player)
		{
			return false;
		}

		protected virtual bool IsCostumeChangeAllowed()
		{
			return false;
		}

		protected virtual void onLobbyStateChange(LocalPlayerInfomationCache player, LobbyState.State newState)
		{
		}

		protected virtual void OnExit()
		{
		}

		protected virtual bool CanExitCheck(bool wantsTo)
		{
			return false;
		}

		protected virtual bool ForceExit()
		{
			return false;
		}

		protected bool ButtonPressCheck(int playerID, InputMap input, ref float cooler)
		{
			return false;
		}

		public virtual void ColourChange(LocalPlayerInfomationCache player, int change, bool freeOld = true)
		{
		}

		public void CostumeChange(LocalPlayerInfomationCache player, int change)
		{
		}

		public void TeamChange(LocalPlayerInfomationCache player, int change)
		{
		}

		public void PromptExit()
		{
		}

		public void ConfirmExit()
		{
		}

		public void ConfirmStay()
		{
		}

		[IteratorStateMachine(typeof(_003CApplyStay_003Ed__47))]
		public IEnumerator ApplyStay()
		{
			return null;
		}

		private void LocalBeastSetupTracker_OnStateChange(LocalPlayerInfomationCache arg1, BeastUtils.PlayerState arg2)
		{
		}

		public void UpdateTeamColourUI()
		{
		}

		private void OnApplicationFocus(bool focus)
		{
		}
	}
}
