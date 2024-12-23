using System;
using System.Runtime.CompilerServices;
using CoreNet.Components;
using UnityEngine;

namespace GB.Networking.Components.Client
{
	public class GBClientGameRoundEventHandler : NetComponent
	{
		public delegate void RoundEventDel();

		public static event RoundEventDel PreRoundEndEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event RoundEventDel RoundStartEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event RoundEventDel PreGameEndEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event RoundEventDel GameEndEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

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

		private Action OnPreRoundEnd()
		{
			return null;
		}

		private Action OnRoundStartEvent()
		{
			return null;
		}

		private Action OnGamePreEndEvent()
		{
			return null;
		}

		private Action OnGameEndEvent()
		{
			return null;
		}

		private void OnClientDisconnected(string reason)
		{
		}
	}
}
