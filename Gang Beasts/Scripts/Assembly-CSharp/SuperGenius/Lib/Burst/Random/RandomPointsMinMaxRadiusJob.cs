using System;
using SuperGenius.Lib.Burst.Easing;
using SuperGenius.Lib.Burst.Geometry;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace SuperGenius.Lib.Burst.Random
{
	public class RandomPointsMinMaxRadiusJob : IDisposable
	{
		public NativeList<float3> RandomPoints;

		public RandomPointsMinMaxRadiusJob(int randomPointsCount = 75)
		{
		}

		public JobHandle CreateJob(uint randomSeed, Bounds bounds, float minRadius, float maxRadius, int maxPoints = 75, EaseFuctions.EaseType easeType = EaseFuctions.EaseType.None, bool skipSafetyCheck = false)
		{
			return default(JobHandle);
		}

		public JobHandle CreateJob(uint randomSeed, Bounds bounds, float3 scale, float minRadius, float maxRadius, int maxPoints = 75, EaseFuctions.EaseType easeType = EaseFuctions.EaseType.None, bool skipSafetyCheck = false)
		{
			return default(JobHandle);
		}

		public JobHandle CreateJob(JobHandle dependencies, uint randomSeed, Bounds bounds, float minRadius, float maxRadius, int maxPoints = 75, EaseFuctions.EaseType easeType = EaseFuctions.EaseType.None, bool skipSafetyCheck = false)
		{
			return default(JobHandle);
		}

		public void Dispose()
		{
		}
	}
}
