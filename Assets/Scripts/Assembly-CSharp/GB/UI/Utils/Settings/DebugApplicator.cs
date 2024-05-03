using UnityEngine;

namespace GB.UI.Utils.Settings
{
	public class DebugApplicator : OptionsMenu
	{
		[SerializeField]
		private IntSliderOptionHandler actorSolverIterationsRef;

		[SerializeField]
		private IntSliderOptionHandler actorSolverVelocityIterationsRef;

		[SerializeField]
		private BoolOptionHandler resetFPSCountersRef;

		private int tempActorSolverIterations;

		private int tempActorSolverVelocityIterations;

		private bool tempResetFPSCounters;

		private bool _setup;

		public void UpdateActorSolverIterations(int actorSolverIterations)
		{
		}

		public void UpdateActorSolverVelocityIterations(int actorSolverVelocityIterations)
		{
		}

		public void UpdateResetFPSCounters(bool resetFPSCounters)
		{
		}

		public void UpdateAllActorSolverIterations()
		{
		}

		public override void SetupSettings()
		{
		}

		public override void ApplySettings()
		{
		}

		public override void RejectSettings()
		{
		}

		public override bool HaveSettingsChanged()
		{
			return false;
		}
	}
}
