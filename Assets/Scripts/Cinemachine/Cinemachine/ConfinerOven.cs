using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	internal class ConfinerOven
	{
		public class BakedSolution
		{
			private float m_frustumSizeIntSpace;

			private readonly AspectStretcher m_AspectStretcher;

			private readonly bool m_HasBones;

			private readonly double m_SqrPolygonDiagonal;

			private List<List<ClipperLib.IntPoint>> m_OriginalPolygon;

			public List<List<ClipperLib.IntPoint>> m_Solution;

			private const double k_ClipperEpsilon = 1000.0;

			public float FrustumHeight { get; }

			public BakedSolution(float aspectRatio, float frustumHeight, bool hasBones, Rect polygonBounds, List<List<ClipperLib.IntPoint>> originalPolygon, List<List<ClipperLib.IntPoint>> solution)
			{
			}

			public void Clear()
			{
			}

			public bool IsValid(float frustumHeight)
			{
				return false;
			}

			public Vector2 ConfinePoint(in Vector2 pointToConfine)
			{
				return default(Vector2);
			}

			private bool IsInsideOriginal(ClipperLib.IntPoint p)
			{
				return false;
			}

			private static float ClosestPointOnSegment(ClipperLib.IntPoint p, ClipperLib.IntPoint s0, ClipperLib.IntPoint s1)
			{
				return 0f;
			}

			private static ClipperLib.IntPoint IntPointLerp(ClipperLib.IntPoint a, ClipperLib.IntPoint b, float lerp)
			{
				return default(ClipperLib.IntPoint);
			}

			private bool DoesIntersectOriginal(ClipperLib.IntPoint l1, ClipperLib.IntPoint l2)
			{
				return false;
			}

			private static int FindIntersection(in ClipperLib.IntPoint p1, in ClipperLib.IntPoint p2, in ClipperLib.IntPoint p3, in ClipperLib.IntPoint p4)
			{
				return 0;
			}

			private static double IntPointDiffSqrMagnitude(ClipperLib.IntPoint p1, ClipperLib.IntPoint p2)
			{
				return 0.0;
			}
		}

		private struct AspectStretcher
		{
			private readonly float m_InverseAspect;

			private readonly float m_CenterX;

			public float Aspect { get; }

			public AspectStretcher(float aspect, float centerX)
			{
				Aspect = 0f;
				m_InverseAspect = 0f;
				m_CenterX = 0f;
			}

			public Vector2 Stretch(Vector2 p)
			{
				return default(Vector2);
			}

			public Vector2 Unstretch(Vector2 p)
			{
				return default(Vector2);
			}
		}

		private struct PolygonSolution
		{
			public List<List<ClipperLib.IntPoint>> m_Polygons;

			public float m_FrustumHeight;

			public bool IsEmpty => false;

			public bool StateChanged(in List<List<ClipperLib.IntPoint>> paths)
			{
				return false;
			}
		}

		public enum BakingState
		{
			BAKING = 0,
			BAKED = 1,
			TIMEOUT = 2
		}

		private struct BakingStateCache
		{
			public ClipperLib.ClipperOffset offsetter;

			public List<PolygonSolution> solutions;

			public PolygonSolution rightCandidate;

			public PolygonSolution leftCandidate;

			public List<List<ClipperLib.IntPoint>> maxCandidate;

			public float stepSize;

			public float maxFrustumHeight;

			public float currentFrustumHeight;

			public float bakeTime;
		}

		private float m_MinFrustumHeightWithBones;

		private List<List<ClipperLib.IntPoint>> m_OriginalPolygon;

		private List<List<ClipperLib.IntPoint>> m_Skeleton;

		private const long k_FloatToIntScaler = 100000L;

		private const float k_IntToFloatScaler = 1E-05f;

		private const float k_MinStepSize = 0.005f;

		private Rect m_PolygonRect;

		private AspectStretcher m_AspectStretcher;

		private float m_maxComputationTimeForFullSkeletonBakeInSeconds;

		public float m_BakeProgress;

		private BakingStateCache m_Cache;

		public BakingState State { get; private set; }

		public ConfinerOven(in List<List<Vector2>> inputPath, in float aspectRatio, float maxFrustumHeight)
		{
		}

		public BakedSolution GetBakedSolution(float frustumHeight)
		{
			return null;
		}

		private void Initialize(in List<List<Vector2>> inputPath, in float aspectRatio, float maxFrustumHeight)
		{
		}

		public void BakeConfiner(float maxComputationTimePerFrameInSeconds)
		{
		}

		private static Rect GetPolygonBoundingBox(in List<List<Vector2>> polygons)
		{
			return default(Rect);
		}

		private void ComputeSkeleton(in List<PolygonSolution> solutions)
		{
		}
	}
}
