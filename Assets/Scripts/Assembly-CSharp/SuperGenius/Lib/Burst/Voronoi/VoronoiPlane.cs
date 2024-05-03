using System;
using SuperGenius.Lib.Burst.Geometry;
using Unity.Burst;

namespace SuperGenius.Lib.Burst.Voronoi
{
	[Serializable]
	[BurstCompile]
	public struct VoronoiPlane
	{
		public Plane _plane;

		public int PairedIndex;

		public bool Removed;

		public bool Added;
	}
}
