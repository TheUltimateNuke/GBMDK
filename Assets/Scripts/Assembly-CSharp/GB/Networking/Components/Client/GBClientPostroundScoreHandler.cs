using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Components;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.Networking.Components.Client
{
	public class GBClientPostroundScoreHandler : NetComponent
	{
		[CompilerGenerated]
		private sealed class _003CDisplayScreen_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GBClientPostroundScoreHandler _003C_003E4__this;

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
			public _003CDisplayScreen_003Ed__28(int _003C_003E1__state)
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

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		private static GBClientPostroundScoreHandler instance;

		private bool hasInitialSetup;

		private LayerMask UIMask;

		private Color CoinScreenBackgroundColour;

		private CameraClearFlags CoinScreenClearFlags;

		private LayerMask previousMask;

		private Color previousBGColor;

		private string uiCameraResource;

		private GameObject uiCamera;

		private bool _ShowScreen;

		private Coroutine _displayRunning;

		public static GBClientPostroundScoreHandler Instance => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private bool ScoreScreenBlocked()
		{
			return false;
		}

		private void OnGangAdded(NetGang item)
		{
		}

		private void OnGangUpdated(NetGang item)
		{
		}

		private void OnGangRemoved(NetGang item)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnLevelChanged(Scene previous, Scene next)
		{
		}

		private void OnLevelBegin()
		{
		}

		private void OnNewLevelBegin()
		{
		}

		private void OnPostRoundBegin()
		{
		}

		private void StartDisplay()
		{
		}

		private void UpdateScoreboard(NetGang[] gangs)
		{
		}

		public void SetupCoinScreen()
		{
		}

		[IteratorStateMachine(typeof(_003CDisplayScreen_003Ed__28))]
		private IEnumerator DisplayScreen()
		{
			return null;
		}

		private void HideScreen()
		{
		}
	}
}
