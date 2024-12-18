using System.Collections.Generic;
using UnityEngine;

namespace GB.View.UI
{
	public class BoundUIController : UIController
	{
		private List<RectTransform> registeredUIElements;

		[SerializeField]
		private Vector2 caches;

		[SerializeField]
		private Vector4 debug;

		[SerializeField]
		private int pixelSafeZoneHorizontal;

		[SerializeField]
		private int pixelSafeZoneVertical;

		[SerializeField]
		private bool snapOnCollision;

		private float cachedRectMaxX;

		private float cachedRectMaxY;

		public new void Awake()
		{
		}

		public void LateUpdate()
		{
		}

		public void AddUIElement(RectTransform xform)
		{
		}

		public void RemoveUIElement(RectTransform xform)
		{
		}

		private void FlushElements()
		{
		}

		private void EdgeCheckElements()
		{
		}

		private void InterCheckElements()
		{
		}
	}
}
