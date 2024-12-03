using UnityEngine;
using UnityEngine.InputSystem;

namespace Cinemachine
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineAlternativeInput.html")]
	public class CinemachineInputProvider : MonoBehaviour, AxisState.IInputAxisProvider
	{
		[Tooltip("Leave this at -1 for single-player games.  For multi-player games, set this to be the player index, and the actions will be read from that player's controls")]
		public int PlayerIndex;

		[Tooltip("If set, Input Actions will be auto-enabled at start")]
		public bool AutoEnableInputs;

		[Tooltip("Vector2 action for XY movement")]
		public InputActionReference XYAxis;

		[Tooltip("Float action for Z movement")]
		public InputActionReference ZAxis;

		private const int NUM_AXES = 3;

		private InputAction[] m_cachedActions;

		public virtual float GetAxisValue(int axis)
		{
			return 0f;
		}

		protected InputAction ResolveForPlayer(int axis, InputActionReference actionRef)
		{
			return null;
		}

		protected virtual void OnDisable()
		{
		}
	}
}
