using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class TentacleSegmentManager : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CEnableSegmentManager_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TentacleSegmentManager _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

        void IAsyncStateMachine.MoveNext()
        {
            throw new System.NotImplementedException();
        }

        [DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

        void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
        {
            throw new System.NotImplementedException();
        }
    }

	private const int k_TentacleControllersPerAlloc = 10;

	public List<TentacleController> m_TentacleControllers;

	private bool m_segmentMaangerAllowUpdates;

	private bool oddPass;

	public static TentacleSegmentManager Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void GameStarted()
	{
	}

	[AsyncStateMachine(typeof(_003CEnableSegmentManager_003Ed__10))]
	private void EnableSegmentManager()
	{
	}

	private void FixedUpdate()
	{
	}

	public void AddTentacleController(TentacleController controller)
	{
	}

	public void RemoveTentacleController(TentacleController controller)
	{
	}
}
