using UnityEngine;

namespace GB.View.UI
{
	public class UISafeZoneScaler : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _target;

		[SerializeField]
		private RectTransform _parent;

		[SerializeField]
		private Vector2 _targetSize;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void PlatformEvents_OnPlatformGamePauseEvent(bool effect)
		{
		}

		private void OnEnable()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}
	}
}
