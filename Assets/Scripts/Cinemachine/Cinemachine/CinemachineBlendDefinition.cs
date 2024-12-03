using System;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct CinemachineBlendDefinition
	{
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum Style
		{
			Cut = 0,
			EaseInOut = 1,
			EaseIn = 2,
			EaseOut = 3,
			HardIn = 4,
			HardOut = 5,
			Linear = 6,
			Custom = 7
		}

		[Tooltip("Shape of the blend curve")]
		public Style m_Style;

		[Tooltip("Duration of the blend, in seconds")]
		public float m_Time;

		public AnimationCurve m_CustomCurve;

		private static AnimationCurve[] sStandardCurves;

		public float BlendTime => 0f;

		public AnimationCurve BlendCurve => null;

		public CinemachineBlendDefinition(Style style, float time)
		{
			m_Style = default(Style);
			m_Time = 0f;
			m_CustomCurve = null;
		}

		private void CreateStandardCurves()
		{
		}
	}
}
