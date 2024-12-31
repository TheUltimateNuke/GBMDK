using System;
using System.Collections.Generic;
using System.IO;
using Coatsink.Common;
using UnityEngine;

[Serializable]
[Serializer.ExcludeAllFields]
public struct v2i : Serializer.ISelfConstructor
{
	private class EQComparer : EqualityComparer<v2i>
	{
		public override bool Equals(v2i v1, v2i v2)
		{
			return false;
		}

		public override int GetHashCode(v2i v)
		{
			return 0;
		}
	}

	public int x;

	public int y;

	public static readonly v2i zero;

	public static readonly v2i one;

	public static readonly v2i left;

	public static readonly v2i right;

	public static readonly v2i up;

	public static readonly v2i down;

	public static readonly EqualityComparer<v2i> eqComparer;

	public float Magnitude => 0f;

	public int this[uint index]
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public v2i(int x, int y)
	{
		this.x = 0;
		this.y = 0;
	}

	public v2i(Vector2 v)
	{
		x = 0;
		y = 0;
	}

	private v2i(BinaryReader reader)
	{
		x = 0;
		y = 0;
	}

	public void Deconstruct(BinaryWriter writer)
	{
	}

	public static v2i operator +(v2i lhs, v2i rhs)
	{
		return default(v2i);
	}

	public static v2i operator -(v2i lhs, v2i rhs)
	{
		return default(v2i);
	}

	public static v2i operator *(v2i lhs, int scalar)
	{
		return default(v2i);
	}

	public static v2i operator /(v2i lhs, int scalar)
	{
		return default(v2i);
	}

	public static v2i operator -(v2i v0)
	{
		return default(v2i);
	}

	public static v2i operator +(v2i v0, OctDir dir)
	{
		return default(v2i);
	}

	public static v2i operator -(v2i v0, OctDir dir)
	{
		return default(v2i);
	}

	public static v2i Scale(v2i v0, v2i v1)
	{
		return default(v2i);
	}

	public static v2i InvScale(v2i v0, v2i v1)
	{
		return default(v2i);
	}

	public static Vector2 InvScaleFloat(v2i v0, v2i v1)
	{
		return default(Vector2);
	}

	public static v2i Min(v2i v0, v2i v1)
	{
		return default(v2i);
	}

	public static v2i Max(v2i v0, v2i v1)
	{
		return default(v2i);
	}

	public static int Dot(v2i v0, v2i v1)
	{
		return 0;
	}

	public static int DistanceSqr(v2i v0, v2i v1)
	{
		return 0;
	}

	public static float Distance(v2i v0, v2i v1)
	{
		return 0f;
	}

	public static int ManhattanDistance(v2i v0, v2i v1)
	{
		return 0;
	}

	public static bool IsNeighbour(v2i v0, v2i v1)
	{
		return false;
	}

	public static v2i Normalize(v2i dir)
	{
		return default(v2i);
	}

	public static v2i DirectionXZ(Vector3 direction)
	{
		return default(v2i);
	}

	public static Vector3 DirectionXZ(v2i direction)
	{
		return default(Vector3);
	}

	public static bool operator ==(v2i lhs, v2i rhs)
	{
		return false;
	}

	public static bool operator !=(v2i lhs, v2i rhs)
	{
		return false;
	}

	public v2i SimpleClamped(float newMaxMag)
	{
		return default(v2i);
	}

	public override string ToString()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
