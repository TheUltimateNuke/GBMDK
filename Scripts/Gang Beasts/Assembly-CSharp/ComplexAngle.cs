using System;
using UnityEngine;

[Serializable]
public struct ComplexAngle
{
	public float r;

	public float i;

	public const float cwRevRadians = (float)Math.PI * -2f;

	public const float cwRevDegrees = 360f;

	public static readonly ComplexAngle radian;

	public static readonly ComplexAngle cwDegree;

	public static readonly ComplexAngle cwRev;

	public static readonly ComplexAngle zero;

	public static readonly ComplexAngle cwQuarter;

	public static readonly ComplexAngle cwHalf;

	public static readonly ComplexAngle cwThreeQuarters;

	public float euler => 0f;

	public Vector2 direction => default(Vector2);

	public Vector3 directionXZ => default(Vector3);

	public Vector3 directionXY => default(Vector3);

	public Vector3 directionYZ => default(Vector3);

	public ComplexAngle normalize => default(ComplexAngle);

	public ComplexAngle conjugate => default(ComplexAngle);

	public ComplexAngle(float r, float c)
	{
		this.r = 0f;
		i = 0f;
	}

	public override string ToString()
	{
		return null;
	}

	public static ComplexAngle FromEuler(float angle)
	{
		return default(ComplexAngle);
	}

	public static ComplexAngle FromVec(Vector2 dir)
	{
		return default(ComplexAngle);
	}

	public static ComplexAngle FromVecXZ(Vector3 dir)
	{
		return default(ComplexAngle);
	}

	public static ComplexAngle FromVecPrenormalized(Vector2 direction)
	{
		return default(ComplexAngle);
	}

	public static ComplexAngle FromVecXYPrenormalized(Vector3 direction)
	{
		return default(ComplexAngle);
	}

	public static ComplexAngle FromVecYZPrenormalized(Vector3 direction)
	{
		return default(ComplexAngle);
	}

	public static ComplexAngle FromVecXZPrenormalized(Vector3 direction)
	{
		return default(ComplexAngle);
	}

	public static Vector2 operator *(ComplexAngle a, Vector2 b)
	{
		return default(Vector2);
	}

	public static ComplexAngle operator *(ComplexAngle a, float s)
	{
		return default(ComplexAngle);
	}

	public static ComplexAngle operator -(ComplexAngle a, ComplexAngle b)
	{
		return default(ComplexAngle);
	}

	public static ComplexAngle operator +(ComplexAngle a, ComplexAngle b)
	{
		return default(ComplexAngle);
	}

	public static ComplexAngle operator *(ComplexAngle a, ComplexAngle b)
	{
		return default(ComplexAngle);
	}

	public static float GetEulerBetween(ComplexAngle a, ComplexAngle b)
	{
		return 0f;
	}

	public static ComplexAngle Nlerp(ComplexAngle a, ComplexAngle b, float t)
	{
		return default(ComplexAngle);
	}

	public static ComplexAngle Slerp(ComplexAngle a, ComplexAngle b, float t)
	{
		return default(ComplexAngle);
	}
}
