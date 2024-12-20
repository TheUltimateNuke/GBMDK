namespace Technie.PhysicsCreator.QHull
{
	public class Vertex
	{
		public Point3d pnt;

		public int index;

		public Vertex prev;

		public Vertex next;

		public Face face;

		public Vertex()
		{
		}

		public Vertex(double x, double y, double z, int idx)
		{
		}
	}
}
