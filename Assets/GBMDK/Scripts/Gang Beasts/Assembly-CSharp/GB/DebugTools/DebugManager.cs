using CoreNet.Model;
using UnityEngine;

namespace GB.DebugTools
{
	public class DebugManager : MonoBehaviour
	{
		private static readonly int FPS_BUFFER_SIZE;

		[SerializeField]
		[Tooltip("Debug Variables controller reference")]
		private DebugVariables _debugVariables;

		private DebugVariable<string> _fpsVariable;

		private DebugVariable<string> _pingVariable;

		private DebugVariable<string> _memoryVariable;

		private NetModel _Model;

		private PostCompileInfo serverInfo;

		private int[] fpsBuffer;

		private int currentFrame;

		private DebugVariable<string> serverBranch;

		private DebugVariable<string> serverHash;

		private DebugVariable<string> serverBuildDate;

		private DebugVariable<string> serverNetVersion;

		private PhysicsDebugManager _physicsDebugManager;

		public static bool ResetFPSStats { get; internal set; }

		public void Start()
		{
		}

		private void OnNetRoundOrganiserStarted()
		{
		}

		private void OnRoundStart()
		{
		}

		private void OnServerInfoSet(PostCompileInfo item)
		{
		}

		private void ShowVersionInfo()
		{
		}

		private void ShowPerformanceInfo()
		{
		}

		private void ShowPhysicsInfo()
		{
		}

		private void UpdatePhysicsInfo()
		{
		}
	}
}
