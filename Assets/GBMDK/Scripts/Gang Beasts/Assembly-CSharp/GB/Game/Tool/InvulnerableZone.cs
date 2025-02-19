using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Game.Tool.ActorEvents;
using UnityEngine;

namespace GB.Game.Tool
{
	public class InvulnerableZone : MonoBehaviour, IActorOnTriggerEvent
	{
		[CompilerGenerated]
		private sealed class _003CInvulnerableUpdate_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InvulnerableZone _003C_003E4__this;

			public Actor actor;

			private float _003Ctimer_003E5__2;

			private int _003CnextlastShow_003E5__3;

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
			public _003CInvulnerableUpdate_003Ed__17(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CReapplyCooldown_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InvulnerableZone _003C_003E4__this;

			public Actor actor;

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
			public _003CReapplyCooldown_003Ed__19(int _003C_003E1__state)
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

		[SerializeField]
		private bool _reapply;

		[SerializeField]
		private float _timer;

		[SerializeField]
		private Collider _bounds;

		[SerializeField]
		private bool _gainOnEnter;

		[SerializeField]
		private bool _lossOnLeft;

		[SerializeField]
		private bool _invulnerable;

		[SerializeField]
		private bool _immortal;

		[SerializeField]
		private bool _inverse;

		[SerializeField]
		private float _coolDown;

		private Dictionary<Actor, Coroutine> _activeBeasts;

		private void OnEnable()
		{
		}

		private void OnActorStateChangedServer(Actor actor, int connectionID, Actor.ActorState state)
		{
		}

		private void OnDisable()
		{
		}

		private void OnActorDestroyed(Actor obj)
		{
		}

		private void Update()
		{
		}

		private bool InArea(Actor actor)
		{
			return false;
		}

		public void StartInvulnerablility(Actor actor)
		{
		}

		[IteratorStateMachine(typeof(_003CInvulnerableUpdate_003Ed__17))]
		private IEnumerator InvulnerableUpdate(Actor actor)
		{
			return null;
		}

		private void EndInvulnerablility(Actor actor, bool cooldown)
		{
		}

		[IteratorStateMachine(typeof(_003CReapplyCooldown_003Ed__19))]
		private IEnumerator ReapplyCooldown(Actor actor)
		{
			return null;
		}

		public void Event(Actor actor)
		{
		}
	}
}
