using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Coatsink.UnityServices.Authentication;
using Coatsink.UnityServices.Matchmaking;
using Coatsink.UnityServices.QoS;
using UnityEngine;

namespace Coatsink.UnityServices
{
	public class UnityServicesManager : MonoBehaviour
	{
		[Flags]
		public enum InitialiseFlags
		{
			None = 1,
			GameClient = 2,
			DedicatedServer = 4
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CIntialiseAsync_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public UnityServicesManager _003C_003E4__this;

			public string profileName;

			public InitialiseFlags initialiseFlags;

			public string multiplayFleetId;

			public Action InitialisedCallback;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<AuthState> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				SetStateMachine(stateMachine);
			}
		}

		private static UnityServicesManager instance;

		private MultiplayQoSWrapper qosWrapper;

		private MatchmakingManager matchmakingManager;

		private MultiplayAllocationService allocationService;

		private MultiplayServerQueryService serverQueryService;

		public bool Initialised { get; private set; }

		public string ProfileName { get; private set; }

		public string PlayerId { get; private set; }

		public static UnityServicesManager Instance => null;

		public MatchmakingManager MatchmakingManager => null;

		public MultiplayQoSWrapper QosWrapper => null;

		public MultiplayServerQueryService ServerQueryService => null;

		public MultiplayAllocationService AllocationManager => null;

		public void Initialise(InitialiseFlags initialiseFlags, Action InitialisedCallback, string multiplayFleetId, string profileName)
		{
		}

		[AsyncStateMachine(typeof(_003CIntialiseAsync_003Ed__29))]
		private void IntialiseAsync(InitialiseFlags initialiseFlags, Action InitialisedCallback, string multiplayFleetId, string profileName)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
