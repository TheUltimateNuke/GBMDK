using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Unity.Services.Matchmaker.Models;
using Unity.Services.Qos;

namespace Coatsink.UnityServices.QoS
{
	public class MultiplayQoSWrapper
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CStartQosDiscoveryAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MultiplayQoSWrapper _003C_003E4__this;

			private TaskAwaiter<QosResult[]> _003C_003Eu__1;

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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CStartQosDiscoveryInternal_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<QosResult[]> _003C_003Et__builder;

			public MultiplayQoSWrapper _003C_003E4__this;

			private List<QosResult> _003ClistQoSResults_003E5__2;

			private Dictionary<string, List<string>>.Enumerator _003C_003E7__wrap2;

			private KeyValuePair<string, List<string>> _003CqosRegionsByMpRegion_003E5__4;

			private TaskAwaiter<IList<IQosResult>> _003C_003Eu__1;

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

		public const float QosResultFrequencySeconds = 300f;

		private float qosTimer;

		private object _locker;

		private bool _updating;

		private Action _waitingAction;

		private QosResult[] _results;

		public QosResult[] QosResults => null;

		public string FleetId { get; private set; }

		public void ForceUpdate(Action onComplete)
		{
		}

		public void ForgetWaiting()
		{
		}

		public MultiplayQoSWrapper(string fleetId)
		{
		}

		public void Update(float dt)
		{
		}

		private void RunUpdate()
		{
		}

		[AsyncStateMachine(typeof(_003CStartQosDiscoveryAsync_003Ed__17))]
		private void StartQosDiscoveryAsync()
		{
		}

		[AsyncStateMachine(typeof(_003CStartQosDiscoveryInternal_003Ed__18))]
		private Task<QosResult[]> StartQosDiscoveryInternal()
		{
			return null;
		}
	}
}
