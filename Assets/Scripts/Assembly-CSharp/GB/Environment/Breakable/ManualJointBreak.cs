using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.Environment.Breakable
{
	public class ManualJointBreak : MonoBehaviour, IBreakable
	{
		[SerializeField]
		private Joint _joint;

		public bool IsBroken => false;

		public event IBreakable.BreakableEvent OnBroken
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

		public void Awake()
		{
		}

		public void Break()
		{
		}
	}
}
