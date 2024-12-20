using System.Collections.Generic;
using UnityEngine;

namespace GB.View
{
	public class CameraAnchor : MonoBehaviour
	{
		[SerializeField]
		private int _Id;

		public CameraAnchor PreviousAnchorRef;

		public CameraAnchor NextAnchorRef;

		public static bool alwaysShowGizmos;

		[SerializeField]
		public List<Renderer> _disableList;

		[SerializeField]
		public bool isDefaultAnchor;

		public int ID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual CameraAnchor PreviousAnchor => null;

		public virtual CameraAnchor NextAnchor => null;

		public void Set(Transform t)
		{
		}

		public void Set(Vector3 pos, Quaternion rot)
		{
		}

		public static int compareID(CameraAnchor a, CameraAnchor b)
		{
			return 0;
		}

		public void LeftAnchor()
		{
		}

		public void EnterAnchor()
		{
		}
	}
}
