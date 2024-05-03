using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class DynamicShadowSettings : MonoBehaviour
	{
		public Light sunLight;

		public float minHeight;

		public float minShadowDistance;

		public float minShadowBias;

		public float maxHeight;

		public float maxShadowDistance;

		public float maxShadowBias;

		public float adaptTime;

		private float m_SmoothHeight;

		private float m_ChangeSpeed;

		private float m_OriginalStrength;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
