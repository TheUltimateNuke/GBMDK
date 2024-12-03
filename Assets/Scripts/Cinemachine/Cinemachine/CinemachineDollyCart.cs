using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineDollyCart.html")]
	public class CinemachineDollyCart : MonoBehaviour
	{
		public enum UpdateMethod
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}

		[Tooltip("The path to follow")]
		public CinemachinePathBase m_Path;

		[Tooltip("When to move the cart, if Velocity is non-zero")]
		public UpdateMethod m_UpdateMethod;

		[Tooltip("How to interpret the Path Position.  If set to Path Units, values are as follows: 0 represents the first waypoint on the path, 1 is the second, and so on.  Values in-between are points on the path in between the waypoints.  If set to Distance, then Path Position represents distance along the path.")]
		public CinemachinePathBase.PositionUnits m_PositionUnits;

		[FormerlySerializedAs("m_Velocity")]
		[Tooltip("Move the cart with this speed along the path.  The value is interpreted according to the Position Units setting.")]
		public float m_Speed;

		[Tooltip("The position along the path at which the cart will be placed.  This can be animated directly or, if the velocity is non-zero, will be updated automatically.  The value is interpreted according to the Position Units setting.")]
		[FormerlySerializedAs("m_CurrentDistance")]
		public float m_Position;

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void SetCartPosition(float distanceAlongPath)
		{
		}
	}
}
