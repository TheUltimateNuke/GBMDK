using System;
using SuperGenius.Lib.Burst.MeshModification;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace SuperGenius.Lib.Burst.Geometry
{
	[Serializable]
	[BurstCompile]
	public struct Bounds
	{
		[SerializeField]
		private float3 _center;

		[SerializeField]
		private float3 _extents;

		private bool _isValid;

		public Bounds(UnityEngine.Bounds bounds):this()
		{
		}

		public Bounds(UnityEngine.Bounds bounds, float3 scale):this()
		{
		}

		public Bounds(Bounds bounds, float3 scale):this()
		{
		}

		public Bounds(float3 center, float3 extents):this()
		{
		}

		public Bounds(ref MeshData meshData):this()
		{
		}

		public void UpdateBounds(ref MeshData meshData)
		{
		}

		public bool SetMinMax(float3 min, float3 max)
		{
			return false;
		}

		public void Scale(float3 scale)
		{
		}

		public float3 Center()
		{
			return default(float3);
		}

		public float3 Extents()
		{
			return default(float3);
		}

		public float3 Max()
		{
			return default(float3);
		}

		public float3 Min()
		{
			return default(float3);
		}

		public float3 Size()
		{
			return default(float3);
		}

		public bool IsValid()
		{
			return false;
		}

		public bool UpdateValid()
		{
			return false;
		}

		public static bool IsValid([Unity.Collections.ReadOnly] float3 min, [Unity.Collections.ReadOnly] float3 max)
		{
			return false;
		}

		public bool Contains(float3 point)
		{
			return false;
		}
	}
}
