using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GB.Game;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Gamemodes.CTF
{
	public class Flag : NetworkBehaviour, IKillTriggered
	{
		[CompilerGenerated]
		private sealed class _003CDestroySelf_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Flag _003C_003E4__this;

			private float _003Ctimer_003E5__2;

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
			public _003CDestroySelf_003Ed__15(int _003C_003E1__state)
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

		[HideInInspector]
		public bool Captured;

		public Action<Flag> OnKilled;

		[SyncVar(hook = "GangIDChanged")]
		private int _gangID;

		[SerializeField]
		private Renderer _targetRenderer;

		[SerializeField]
		private int _materialIndex;

		private Material _targetMaterial;

		public int GangID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private Material TargetMaterial => null;

		public int Network_gangID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		public void GangIDChanged(int value)
		{
		}

		public void Capture()
		{
		}

		private void UpdateColour()
		{
		}

		public void Kill(KillVolumeEvent trigger)
		{
		}

		[IteratorStateMachine(typeof(_003CDestroySelf_003Ed__15))]
		private IEnumerator DestroySelf()
		{
			return null;
		}

		private void UNetVersion()
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			return false;
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		public override void PreStartClient()
		{
		}
	}
}
