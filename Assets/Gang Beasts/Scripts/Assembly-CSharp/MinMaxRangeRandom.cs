using System.Collections.Generic;
using SuperGenius.Lib.Burst.Geometry;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

public class MinMaxRangeRandom : MonoBehaviour
{
	public bool Calculate;

	public float minRadius;

	public float maxRadius;

	public SuperGenius.Lib.Burst.Geometry.Bounds Bounds;

	public uint RandomSeed;

	private List<Vector3> points;

	public NativeList<float3> Locations;

	private void Update()
	{
	}

	private void OnValidate()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void Validate()
	{
	}

	private void Generate()
	{
	}
}
