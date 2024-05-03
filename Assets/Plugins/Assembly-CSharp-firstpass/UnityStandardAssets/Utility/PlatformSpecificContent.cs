using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class PlatformSpecificContent : MonoBehaviour
	{
		private enum BuildTargetGroup
		{
			Standalone = 0,
			Mobile = 1
		}

		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[SerializeField]
		private GameObject[] m_Content;

		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[SerializeField]
		private bool m_ChildrenOfThisObject;

		private void OnEnable()
		{
		}

		private void CheckEnableContent()
		{
		}

		private void EnableContent(bool enabled)
		{
		}
	}
}
