using System;
using Unity.Collections;
using Unity.Mathematics;

namespace SuperGenius.Lib.Burst.Geometry
{
	[Serializable]
	public struct Plane
	{
		public float3 Center;

		public float3 Normal;

		public Plane(float3 center, float3 normal)
		{
			Center = default(float3);
			Normal = default(float3);
		}

		public void CalculateNormal(float3 position)
		{
		}

		public static bool IsBehind([Unity.Collections.ReadOnly] ref Plane plane, [Unity.Collections.ReadOnly] float3 point)
		{
			return false;
		}

		public static bool PlanePlaneIntersection([Unity.Collections.ReadOnly] ref Plane plane1, [Unity.Collections.ReadOnly] ref Plane plane2, ref float3 intersectionPoint, ref float3 intersectionDirection)
		{
			return false;
		}

		public static bool LineCast([Unity.Collections.ReadOnly] ref Plane plane, [Unity.Collections.ReadOnly] float3 linePoint, [Unity.Collections.ReadOnly] float3 lineDirection, ref float3 intersectionPoint)
		{
			return false;
		}

		public static bool RayCast([Unity.Collections.ReadOnly] ref Plane plane, [Unity.Collections.ReadOnly] float3 linePoint, [Unity.Collections.ReadOnly] float3 lineDirection, out float hitDistance, [Unity.Collections.ReadOnly] float distance = 0f)
		{
			hitDistance = default(float);
			return false;
		}

		public static bool IsOn(ref Plane plane, float3 vert0)
		{
			return false;
		}
	}
}
