using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CoreNet.Messaging;
using CoreNet.Messaging.Messages;
using CoreNet.Objects;
using GB.Networking.Components.Server;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Components.Server
{
	[RequireComponent(typeof(NetServerExit))]
	public abstract class NetServerMemberManager : NetComponent
	{
		public struct AuthenticationResult
		{
			public bool Success;

			public string Error;
		}

		[CompilerGenerated]
		private sealed class _003CPasswordTimeout_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NetConnection connection;

			public NetServerMemberManager _003C_003E4__this;

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

			object IEnumerator<object>.Current => throw new NotImplementedException();

			object IEnumerator.Current => throw new NotImplementedException();

			[DebuggerHidden]
			public _003CPasswordTimeout_003Ed__24(int _003C_003E1__state)
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

		private int _maxAllowedPlayers;

		protected NetServerExit ServerExit;

		protected GBMultiplayServerCommunicator ServerCommunicator;

		private Dictionary<int, int> reservePlayerSlots;

		public int MaxAllowedPlayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected virtual void OnMaxPlayersUpdated(int newMaxPlayers)
		{
		}

		protected new void Awake()
		{
		}

		private void OnMemberSetupHandler(NetBoolMessage message, NetworkConnection conn)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void OnClientConnectionAdded(NetConnection connection)
		{
		}

		private void OnClientConnectionUpdated(NetConnection connection)
		{
		}

		private void OnClientConnectionRemoved(NetConnection connection)
		{
		}

		private void OnMemberAdded(NetMember member)
		{
		}

		private void OnMemberUpdated(NetMember member)
		{
		}

		private void OnMemberRemoved(NetMember member)
		{
		}

		protected void RegisterPlayersHandler<T>() where T : NetPlayer, new()
		{
		}

		protected void RemovePlayersFromMember<T>(NetMember member) where T : NetPlayer, new()
		{
		}

		protected abstract void RegisterCustomPlayersHandler();

		protected abstract void RemoveCustomPlayersFromMember(NetMember member);

		private void AdmitConnection(NetworkConnection conn, NetAuthMessage message)
		{
		}

		private void AuthenticateConnection(NetConnection connection)
		{
		}

		[IteratorStateMachine(typeof(_003CPasswordTimeout_003Ed__24))]
		private IEnumerator PasswordTimeout(NetConnection connection)
		{
			return null;
		}

		private NetMessenger.MessageCallback<NetPlayersMessage<T>> GetReceivePlayersHandler<T>() where T : NetPlayer, new()
		{
			return null;
		}

		private void RemoveMemberForConnection(NetConnection connection)
		{
		}

		private NetMessenger.MessageCallback<NetAuthMessage> GenerateCredentialHandler()
		{
			return null;
		}

		protected virtual AuthenticationResult Authenticate(NetworkConnection conn, NetAuthMessage message)
		{
			return default(AuthenticationResult);
		}

		protected virtual void FinaliseConnection(NetworkConnection conn, NetAuthMessage message, AuthenticationResult result)
		{
		}
	}
}
