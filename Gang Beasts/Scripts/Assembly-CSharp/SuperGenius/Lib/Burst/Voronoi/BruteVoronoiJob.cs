using System;
using SuperGenius.Lib.Burst.Geometry;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace SuperGenius.Lib.Burst.Voronoi
{
	public class BruteVoronoiJob : IDisposable
	{
		public NativeList<VoronoiPlane> VoronoiPlanes;

		public BruteVoronoiJob(int plansCount = 400)
		{
		}

		public JobHandle CreateJob(Bounds bounds, NativeList<float3> points)
		{
			return default(JobHandle);
		}

		public JobHandle CreateJob(JobHandle dependency, Bounds bounds, NativeList<float3> points)
		{
			return default(JobHandle);
		}

		public void Dispose()
		{
		}
	}
}
