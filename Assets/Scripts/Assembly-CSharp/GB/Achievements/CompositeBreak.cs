using System;
using Femur;
using UnityEngine;

namespace GB.Achievements
{
	[Serializable]
	public class CompositeBreak
	{
		[Tooltip("Break objects referenced by this composite break group")]
		[SerializeField]
		private JointBreakDetect[] ReferencedBreakDectections;

		[SerializeField]
		[Tooltip("Number of referenced objects that must break for this group to be considered satisfied")]
		private int BreaksRequired;

		private bool triggeredAlready;

		private int numBreaksOccured;

		private AchievementBreakDetector parentDetector;

		public void Initialise(AchievementBreakDetector detector)
		{
		}

		public void AlertJointBroke(JointBreakDetect joint, Actor breakingBeast)
		{
		}
	}
}
