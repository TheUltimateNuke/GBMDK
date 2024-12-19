namespace Technie.PhysicsCreator.QHull
{
	public class Face
	{
		public HalfEdge he0;

		private Vector3d normal;

		public double area;

		private Point3d centroid;

		public double planeOffset;

		public int index;

		public int numVerts;

		public Face next;

		public const int VISIBLE = 1;

		public const int NON_CONVEX = 2;

		public const int DELETED = 3;

		public int mark;

		public Vertex outside;

		public void computeCentroid(Point3d centroid)
		{
		}

		public void computeNormal(Vector3d normal, double minArea)
		{
		}

		public void computeNormal(Vector3d normal)
		{
		}

		private void computeNormalAndCentroid()
		{
		}

		private void computeNormalAndCentroid(double minArea)
		{
		}

		public static Face createTriangle(Vertex v0, Vertex v1, Vertex v2)
		{
			return null;
		}

		public static Face createTriangle(Vertex v0, Vertex v1, Vertex v2, double minArea)
		{
			return null;
		}

		public static Face create(Vertex[] vtxArray, int[] indices)
		{
			return null;
		}

		public HalfEdge getEdge(int i)
		{
			return null;
		}

		public HalfEdge getFirstEdge()
		{
			return null;
		}

		public HalfEdge findEdge(Vertex vt, Vertex vh)
		{
			return null;
		}

		public double distanceToPlane(Point3d p)
		{
			return 0.0;
		}

		public Vector3d getNormal()
		{
			return null;
		}

		public Point3d getCentroid()
		{
			return null;
		}

		public int numVertices()
		{
			return 0;
		}

		public string getVertexString()
		{
			return null;
		}

		public void getVertexIndices(int[] idxs)
		{
		}

		private Face connectHalfEdges(HalfEdge hedgePrev, HalfEdge hedge)
		{
			return null;
		}

		public void checkConsistency()
		{
		}

		public int mergeAdjacentFace(HalfEdge hedgeAdj, Face[] discarded)
		{
			return 0;
		}

		private double areaSquared(HalfEdge hedge0, HalfEdge hedge1)
		{
			return 0.0;
		}

		public void triangulate(FaceList newFaces, double minArea)
		{
		}
	}
}
