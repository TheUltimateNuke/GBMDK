using System;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	public struct CinemachineInputAxisDriver
	{
		[Tooltip("Multiply the input by this amount prior to processing.  Controls the input power.")]
		public float multiplier;

		[Tooltip("The amount of time in seconds it takes to accelerate to a higher speed")]
		public float accelTime;

		[Tooltip("The amount of time in seconds it takes to decelerate to a lower speed")]
		public float decelTime;

		[Tooltip("The name of this axis as specified in Unity Input manager. Setting to an empty string will disable the automatic updating of this axis")]
		public string name;

		[Tooltip("The value of the input axis.  A value of 0 means no input.  You can drive this directly from a custom input system, or you can set the Axis Name and have the value driven by the internal Input Manager")]
		[NoSaveDuringPlay]
		public float inputValue;

		private float mCurrentSpeed;

		private const float Epsilon = 0.0001f;

		public void Validate()
		{
		}

		public bool Update(float deltaTime, ref AxisBase axis)
		{
			return false;
		}

		public bool Update(float deltaTime, ref AxisState axis)
		{
			return false;
		}

		private float ClampValue(ref AxisBase axis, float v)
		{
			return 0f;
		}
	}
}
