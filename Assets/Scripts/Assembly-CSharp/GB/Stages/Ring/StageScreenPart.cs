using UnityEngine;

namespace GB.Stages.Ring
{
	public abstract class StageScreenPart : MonoBehaviour
	{
		[SerializeField]
		protected StageScreenPartManager _manager;

		[SerializeField]
		private bool _show;

		public bool Show => false;

		public void SetShow(bool show)
		{
		}

		public virtual void Setup()
		{
		}

		public abstract void OnFocusGained();

		public abstract void OnFocusLossed();

		public virtual void UpdateActive()
		{
		}

		public virtual void Cleanup()
		{
		}
	}
}
