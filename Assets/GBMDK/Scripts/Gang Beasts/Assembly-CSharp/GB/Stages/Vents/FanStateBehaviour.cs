using UnityEngine;

namespace GB.Stages.Vents
{
	public class FanStateBehaviour : StateMachineBehaviour
	{
		private FanController _cachedControllerRef;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		private FanController GetControllerRef(Animator animator)
		{
			return null;
		}
	}
}
