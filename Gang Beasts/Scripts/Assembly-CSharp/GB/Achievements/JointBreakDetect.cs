using CoreNet.Environment.Fracturing;
using Femur;
using GB.Misc;
using UnityEngine;

namespace GB.Achievements
{
	public class JointBreakDetect : MonoBehaviour
	{
		public bool HasTriggeredBreak;

		private CompositeBreak ParentHandlerRef;

		private BaseCable[] LocalCables;

		private NetFractureSync[] LocalFractures;

		private Actor _cachedBreakBeastRef;

		public void Initialise(CompositeBreak handler)
		{
		}

		private void OnDestroy()
		{
		}

		private bool OnFracture(Actor fracturer)
		{
			return false;
		}

		private void OnJointBreak(float breakForce)
		{
		}

		public void BreakTriggered(Actor beast)
		{
		}
	}
}
