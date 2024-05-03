using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class TimedObjectDestructor : MonoBehaviour
	{
		[SerializeField]
		private float m_TimeOut;

		[SerializeField]
		private bool m_DetachChildren;

		private void Awake()
		{
		}

		private void DestroyNow()
		{
		}
	}
}
