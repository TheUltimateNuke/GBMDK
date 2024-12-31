using CoreNet.Environment.Fracturing;
using Femur;
using UnityEngine;
using UnityEngine.Events;

namespace GB.Misc
{
	public class OnFractureEvent : MonoBehaviour
	{
		[SerializeField]
		private NetFractureSync[] _fractureSync;

		[SerializeField]
		private UnityEvent _onFracture;

		private void Awake()
		{
		}

		private void Destroy()
		{
		}

		private bool FractureSync_AdditionalOnFracture(Actor beastRef)
		{
			return false;
		}
	}
}
