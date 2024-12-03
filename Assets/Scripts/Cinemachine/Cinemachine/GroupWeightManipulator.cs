using UnityEngine;

namespace Cinemachine
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.GroupWeightManipulator.html")]
	[RequireComponent(typeof(CinemachineTargetGroup))]
	[ExecuteAlways]
	public class GroupWeightManipulator : MonoBehaviour
	{
		[Tooltip("The weight of the group member at index 0")]
		public float m_Weight0;

		[Tooltip("The weight of the group member at index 1")]
		public float m_Weight1;

		[Tooltip("The weight of the group member at index 2")]
		public float m_Weight2;

		[Tooltip("The weight of the group member at index 3")]
		public float m_Weight3;

		[Tooltip("The weight of the group member at index 4")]
		public float m_Weight4;

		[Tooltip("The weight of the group member at index 5")]
		public float m_Weight5;

		[Tooltip("The weight of the group member at index 6")]
		public float m_Weight6;

		[Tooltip("The weight of the group member at index 7")]
		public float m_Weight7;

		private CinemachineTargetGroup m_group;

		private void Start()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		private void UpdateWeights()
		{
		}
	}
}
