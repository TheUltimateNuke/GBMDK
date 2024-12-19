using System.Runtime.CompilerServices;
using Femur;
using UnityEngine;

namespace GB.Misc
{
	public class BaseCable : MonoBehaviour
	{
		public delegate void BeastAction(Actor beast);

		private bool _jointBroken;

		public event BeastAction OnBreak
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool IsJointBroken()
		{
			return false;
		}

		protected void TriggerJointBreakEvent(Actor beast)
		{
		}
	}
}
