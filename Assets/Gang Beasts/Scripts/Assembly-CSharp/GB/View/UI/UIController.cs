using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.View.UI
{
	public class UIController : MonoBehaviour
	{
		private enum PositionType
		{
			Free = 0,
			Face = 1,
			Anchor = 2
		}

		[Serializable]
		private struct VROverriding
		{
			public bool overridding;

			public PositionType posType;

			public float uiForward;

			public Vector3 offsetPosition;

			public VROverriding(bool active)
			{
				overridding = false;
				posType = default(PositionType);
				uiForward = 0f;
				offsetPosition = default(Vector3);
			}
		}

		public float UIForwardMultiplier;

		[SerializeField]
		private PositionType _positionType;

		[SerializeField]
		private Vector3 _offsetPosition;

		[SerializeField]
		private VROverriding _override;

		protected void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
		{
		}

		private void LateUpdate()
		{
		}

		public void MatchCameraLocation()
		{
		}

		public void MatchAnchorLocation()
		{
		}
	}
}
