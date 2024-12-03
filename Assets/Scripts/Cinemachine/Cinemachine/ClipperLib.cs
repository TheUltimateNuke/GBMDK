using System;
using System.Collections.Generic;

namespace Cinemachine
{
	internal static class ClipperLib
	{
		public struct DoublePoint
		{
			public double X;

			public double Y;

			public DoublePoint(double x = 0.0, double y = 0.0)
			{
				X = 0.0;
				Y = 0.0;
			}

			public DoublePoint(DoublePoint dp)
			{
				X = 0.0;
				Y = 0.0;
			}

			public DoublePoint(IntPoint ip)
			{
				X = 0.0;
				Y = 0.0;
			}
		}

		public class PolyTree : PolyNode
		{
			internal List<PolyNode> m_AllPolys;

			public int Total => 0;

			public void Clear()
			{
			}

			public PolyNode GetFirst()
			{
				return null;
			}
		}

		public class PolyNode
		{
			internal PolyNode m_Parent;

			internal List<IntPoint> m_polygon;

			internal int m_Index;

			internal JoinType m_jointype;

			internal EndType m_endtype;

			internal List<PolyNode> m_Childs;

			public int ChildCount => 0;

			public List<IntPoint> Contour => null;

			public List<PolyNode> Childs => null;

			public PolyNode Parent => null;

			public bool IsHole => false;

			public bool IsOpen { get; set; }

			private bool IsHoleNode()
			{
				return false;
			}

			internal void AddChild(PolyNode Child)
			{
			}

			public PolyNode GetNext()
			{
				return null;
			}

			internal PolyNode GetNextSiblingUp()
			{
				return null;
			}
		}

		internal struct Int128
		{
			private long hi;

			private ulong lo;

			public Int128(long _lo)
			{
				hi = 0L;
				lo = 0uL;
			}

			public Int128(long _hi, ulong _lo)
			{
				hi = 0L;
				lo = 0uL;
			}

			public Int128(Int128 val)
			{
				hi = 0L;
				lo = 0uL;
			}

			public bool IsNegative()
			{
				return false;
			}

			public static bool operator ==(Int128 val1, Int128 val2)
			{
				return false;
			}

			public static bool operator !=(Int128 val1, Int128 val2)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public static bool operator >(Int128 val1, Int128 val2)
			{
				return false;
			}

			public static bool operator <(Int128 val1, Int128 val2)
			{
				return false;
			}

			public static Int128 operator +(Int128 lhs, Int128 rhs)
			{
				return default(Int128);
			}

			public static Int128 operator -(Int128 lhs, Int128 rhs)
			{
				return default(Int128);
			}

			public static Int128 operator -(Int128 val)
			{
				return default(Int128);
			}

			public static explicit operator double(Int128 val)
			{
				return 0.0;
			}

			public static Int128 Int128Mul(long lhs, long rhs)
			{
				return default(Int128);
			}
		}

		public struct IntPoint
		{
			public long X;

			public long Y;

			public IntPoint(long X, long Y)
			{
				this.X = 0L;
				this.Y = 0L;
			}

			public IntPoint(double x, double y)
			{
				X = 0L;
				Y = 0L;
			}

			public IntPoint(IntPoint pt)
			{
				X = 0L;
				Y = 0L;
			}

			public static bool operator ==(IntPoint a, IntPoint b)
			{
				return false;
			}

			public static bool operator !=(IntPoint a, IntPoint b)
			{
				return false;
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

		public struct IntRect
		{
			public long left;

			public long top;

			public long right;

			public long bottom;

			public IntRect(long l, long t, long r, long b)
			{
				left = 0L;
				top = 0L;
				right = 0L;
				bottom = 0L;
			}

			public IntRect(IntRect ir)
			{
				left = 0L;
				top = 0L;
				right = 0L;
				bottom = 0L;
			}
		}

		public enum ClipType
		{
			ctIntersection = 0,
			ctUnion = 1,
			ctDifference = 2,
			ctXor = 3
		}

		public enum PolyType
		{
			ptSubject = 0,
			ptClip = 1
		}

		public enum PolyFillType
		{
			pftEvenOdd = 0,
			pftNonZero = 1,
			pftPositive = 2,
			pftNegative = 3
		}

		public enum JoinType
		{
			jtSquare = 0,
			jtRound = 1,
			jtMiter = 2
		}

		public enum EndType
		{
			etClosedPolygon = 0,
			etClosedLine = 1,
			etOpenButt = 2,
			etOpenSquare = 3,
			etOpenRound = 4
		}

		internal enum EdgeSide
		{
			esLeft = 0,
			esRight = 1
		}

		internal enum Direction
		{
			dRightToLeft = 0,
			dLeftToRight = 1
		}

		internal class TEdge
		{
			internal IntPoint Bot;

			internal IntPoint Curr;

			internal IntPoint Top;

			internal IntPoint Delta;

			internal double Dx;

			internal PolyType PolyTyp;

			internal EdgeSide Side;

			internal int WindDelta;

			internal int WindCnt;

			internal int WindCnt2;

			internal int OutIdx;

			internal TEdge Next;

			internal TEdge Prev;

			internal TEdge NextInLML;

			internal TEdge NextInAEL;

			internal TEdge PrevInAEL;

			internal TEdge NextInSEL;

			internal TEdge PrevInSEL;
		}

		public class IntersectNode
		{
			internal TEdge Edge1;

			internal TEdge Edge2;

			internal IntPoint Pt;
		}

		public class MyIntersectNodeSort : IComparer<IntersectNode>
		{
			public int Compare(IntersectNode node1, IntersectNode node2)
			{
				return 0;
			}
		}

		internal class LocalMinima
		{
			internal long Y;

			internal TEdge LeftBound;

			internal TEdge RightBound;

			internal LocalMinima Next;
		}

		internal class Scanbeam
		{
			internal long Y;

			internal Scanbeam Next;
		}

		internal class Maxima
		{
			internal long X;

			internal Maxima Next;

			internal Maxima Prev;
		}

		internal class OutRec
		{
			internal int Idx;

			internal bool IsHole;

			internal bool IsOpen;

			internal OutRec FirstLeft;

			internal OutPt Pts;

			internal OutPt BottomPt;

			internal PolyNode PolyNode;
		}

		internal class OutPt
		{
			internal int Idx;

			internal IntPoint Pt;

			internal OutPt Next;

			internal OutPt Prev;
		}

		internal class Join
		{
			internal OutPt OutPt1;

			internal OutPt OutPt2;

			internal IntPoint OffPt;
		}

		public class ClipperBase
		{
			internal const double horizontal = -3.4E+38;

			internal const int Skip = -2;

			internal const int Unassigned = -1;

			internal const double tolerance = 1E-20;

			public const long loRange = 1073741823L;

			public const long hiRange = 4611686018427387903L;

			internal LocalMinima m_MinimaList;

			internal LocalMinima m_CurrentLM;

			internal List<List<TEdge>> m_edges;

			internal Scanbeam m_Scanbeam;

			internal List<OutRec> m_PolyOuts;

			internal TEdge m_ActiveEdges;

			internal bool m_UseFullRange;

			internal bool m_HasOpenPaths;

			public bool PreserveCollinear { get; set; }

			internal static bool near_zero(double val)
			{
				return false;
			}

			public void Swap(ref long val1, ref long val2)
			{
			}

			internal static bool IsHorizontal(TEdge e)
			{
				return false;
			}

			internal bool PointIsVertex(IntPoint pt, OutPt pp)
			{
				return false;
			}

			internal bool PointOnLineSegment(IntPoint pt, IntPoint linePt1, IntPoint linePt2, bool UseFullRange)
			{
				return false;
			}

			internal bool PointOnPolygon(IntPoint pt, OutPt pp, bool UseFullRange)
			{
				return false;
			}

			internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange)
			{
				return false;
			}

			internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange)
			{
				return false;
			}

			internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange)
			{
				return false;
			}

			internal ClipperBase()
			{
			}

			public virtual void Clear()
			{
			}

			private void DisposeLocalMinimaList()
			{
			}

			private void RangeTest(IntPoint Pt, ref bool useFullRange)
			{
			}

			private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt)
			{
			}

			private void InitEdge2(TEdge e, PolyType polyType)
			{
			}

			private TEdge FindNextLocMin(TEdge E)
			{
				return null;
			}

			private TEdge ProcessBound(TEdge E, bool LeftBoundIsForward)
			{
				return null;
			}

			public bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed)
			{
				return false;
			}

			public bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed)
			{
				return false;
			}

			internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3)
			{
				return false;
			}

			private TEdge RemoveEdge(TEdge e)
			{
				return null;
			}

			private void SetDx(TEdge e)
			{
			}

			private void InsertLocalMinima(LocalMinima newLm)
			{
			}

			internal bool PopLocalMinima(long Y, out LocalMinima current)
			{
				current = null;
				return false;
			}

			private void ReverseHorizontal(TEdge e)
			{
			}

			internal virtual void Reset()
			{
			}

			public static IntRect GetBounds(List<List<IntPoint>> paths)
			{
				return default(IntRect);
			}

			internal void InsertScanbeam(long Y)
			{
			}

			internal bool PopScanbeam(out long Y)
			{
				Y = default(long);
				return false;
			}

			internal bool LocalMinimaPending()
			{
				return false;
			}

			internal OutRec CreateOutRec()
			{
				return null;
			}

			internal void DisposeOutRec(int index)
			{
			}

			internal void UpdateEdgeIntoAEL(ref TEdge e)
			{
			}

			internal void SwapPositionsInAEL(TEdge edge1, TEdge edge2)
			{
			}

			internal void DeleteFromAEL(TEdge e)
			{
			}
		}

		public class Clipper : ClipperBase
		{
			internal enum NodeType
			{
				ntAny = 0,
				ntOpen = 1,
				ntClosed = 2
			}

			public const int ioReverseSolution = 1;

			public const int ioStrictlySimple = 2;

			public const int ioPreserveCollinear = 4;

			private ClipType m_ClipType;

			private Maxima m_Maxima;

			private TEdge m_SortedEdges;

			private List<IntersectNode> m_IntersectList;

			private IComparer<IntersectNode> m_IntersectNodeComparer;

			private bool m_ExecuteLocked;

			private PolyFillType m_ClipFillType;

			private PolyFillType m_SubjFillType;

			private List<Join> m_Joins;

			private List<Join> m_GhostJoins;

			private bool m_UsingPolyTree;

			public bool ReverseSolution { get; set; }

			public bool StrictlySimple { get; set; }

			public Clipper(int InitOptions = 0)
			{
			}

			private void InsertMaxima(long X)
			{
			}

			public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType FillType = PolyFillType.pftEvenOdd)
			{
				return false;
			}

			public bool Execute(ClipType clipType, PolyTree polytree, PolyFillType FillType = PolyFillType.pftEvenOdd)
			{
				return false;
			}

			public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType subjFillType, PolyFillType clipFillType)
			{
				return false;
			}

			public bool Execute(ClipType clipType, PolyTree polytree, PolyFillType subjFillType, PolyFillType clipFillType)
			{
				return false;
			}

			internal void FixHoleLinkage(OutRec outRec)
			{
			}

			private bool ExecuteInternal()
			{
				return false;
			}

			private void DisposeAllPolyPts()
			{
			}

			private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt)
			{
			}

			private void AddGhostJoin(OutPt Op, IntPoint OffPt)
			{
			}

			private void InsertLocalMinimaIntoAEL(long botY)
			{
			}

			private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge)
			{
			}

			private bool E2InsertsBeforeE1(TEdge e1, TEdge e2)
			{
				return false;
			}

			private bool IsEvenOddFillType(TEdge edge)
			{
				return false;
			}

			private bool IsEvenOddAltFillType(TEdge edge)
			{
				return false;
			}

			private bool IsContributing(TEdge edge)
			{
				return false;
			}

			private void SetWindingCount(TEdge edge)
			{
			}

			private void AddEdgeToSEL(TEdge edge)
			{
			}

			internal bool PopEdgeFromSEL(out TEdge e)
			{
				e = null;
				return false;
			}

			private void CopyAELToSEL()
			{
			}

			private void SwapPositionsInSEL(TEdge edge1, TEdge edge2)
			{
			}

			private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt)
			{
			}

			private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt)
			{
				return null;
			}

			private OutPt AddOutPt(TEdge e, IntPoint pt)
			{
				return null;
			}

			private OutPt GetLastOutPt(TEdge e)
			{
				return null;
			}

			internal void SwapPoints(ref IntPoint pt1, ref IntPoint pt2)
			{
			}

			private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b)
			{
				return false;
			}

			private void SetHoleState(TEdge e, OutRec outRec)
			{
			}

			private double GetDx(IntPoint pt1, IntPoint pt2)
			{
				return 0.0;
			}

			private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2)
			{
				return false;
			}

			private OutPt GetBottomPt(OutPt pp)
			{
				return null;
			}

			private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2)
			{
				return null;
			}

			private bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2)
			{
				return false;
			}

			private OutRec GetOutRec(int idx)
			{
				return null;
			}

			private void AppendPolygon(TEdge e1, TEdge e2)
			{
			}

			private void ReversePolyPtLinks(OutPt pp)
			{
			}

			private static void SwapSides(TEdge edge1, TEdge edge2)
			{
			}

			private static void SwapPolyIndexes(TEdge edge1, TEdge edge2)
			{
			}

			private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt)
			{
			}

			private void DeleteFromSEL(TEdge e)
			{
			}

			private void ProcessHorizontals()
			{
			}

			private void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right)
			{
				Dir = default(Direction);
				Left = default(long);
				Right = default(long);
			}

			private void ProcessHorizontal(TEdge horzEdge)
			{
			}

			private TEdge GetNextInAEL(TEdge e, Direction Direction)
			{
				return null;
			}

			private bool IsMinima(TEdge e)
			{
				return false;
			}

			private bool IsMaxima(TEdge e, double Y)
			{
				return false;
			}

			private bool IsIntermediate(TEdge e, double Y)
			{
				return false;
			}

			internal TEdge GetMaximaPair(TEdge e)
			{
				return null;
			}

			internal TEdge GetMaximaPairEx(TEdge e)
			{
				return null;
			}

			private bool ProcessIntersections(long topY)
			{
				return false;
			}

			private void BuildIntersectList(long topY)
			{
			}

			private bool EdgesAdjacent(IntersectNode inode)
			{
				return false;
			}

			private static int IntersectNodeSort(IntersectNode node1, IntersectNode node2)
			{
				return 0;
			}

			private bool FixupIntersectionOrder()
			{
				return false;
			}

			private void ProcessIntersectList()
			{
			}

			internal static long Round(double value)
			{
				return 0L;
			}

			private static long TopX(TEdge edge, long currentY)
			{
				return 0L;
			}

			private void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip)
			{
				ip = default(IntPoint);
			}

			private void ProcessEdgesAtTopOfScanbeam(long topY)
			{
			}

			private void DoMaxima(TEdge e)
			{
			}

			public static void ReversePaths(List<List<IntPoint>> polys)
			{
			}

			public static bool Orientation(List<IntPoint> poly)
			{
				return false;
			}

			private int PointCount(OutPt pts)
			{
				return 0;
			}

			private void BuildResult(List<List<IntPoint>> polyg)
			{
			}

			private void BuildResult2(PolyTree polytree)
			{
			}

			private void FixupOutPolyline(OutRec outrec)
			{
			}

			private void FixupOutPolygon(OutRec outRec)
			{
			}

			private OutPt DupOutPt(OutPt outPt, bool InsertAfter)
			{
				return null;
			}

			private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right)
			{
				Left = default(long);
				Right = default(long);
				return false;
			}

			private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft)
			{
				return false;
			}

			private bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2)
			{
				return false;
			}

			public static int PointInPolygon(IntPoint pt, List<IntPoint> path)
			{
				return 0;
			}

			private static int PointInPolygon(IntPoint pt, OutPt op)
			{
				return 0;
			}

			private static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2)
			{
				return false;
			}

			private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec)
			{
			}

			private void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec)
			{
			}

			private void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec)
			{
			}

			private static OutRec ParseFirstLeft(OutRec FirstLeft)
			{
				return null;
			}

			private void JoinCommonEdges()
			{
			}

			private void UpdateOutPtIdxs(OutRec outrec)
			{
			}

			private void DoSimplePolygons()
			{
			}

			public static double Area(List<IntPoint> poly)
			{
				return 0.0;
			}

			internal double Area(OutRec outRec)
			{
				return 0.0;
			}

			internal double Area(OutPt op)
			{
				return 0.0;
			}

			public static List<List<IntPoint>> SimplifyPolygon(List<IntPoint> poly, PolyFillType fillType = PolyFillType.pftEvenOdd)
			{
				return null;
			}

			public static List<List<IntPoint>> SimplifyPolygons(List<List<IntPoint>> polys, PolyFillType fillType = PolyFillType.pftEvenOdd)
			{
				return null;
			}

			private static double DistanceSqrd(IntPoint pt1, IntPoint pt2)
			{
				return 0.0;
			}

			private static double DistanceFromLineSqrd(IntPoint pt, IntPoint ln1, IntPoint ln2)
			{
				return 0.0;
			}

			private static bool SlopesNearCollinear(IntPoint pt1, IntPoint pt2, IntPoint pt3, double distSqrd)
			{
				return false;
			}

			private static bool PointsAreClose(IntPoint pt1, IntPoint pt2, double distSqrd)
			{
				return false;
			}

			private static OutPt ExcludeOp(OutPt op)
			{
				return null;
			}

			public static List<IntPoint> CleanPolygon(List<IntPoint> path, double distance = 1.415)
			{
				return null;
			}

			public static List<List<IntPoint>> CleanPolygons(List<List<IntPoint>> polys, double distance = 1.415)
			{
				return null;
			}

			internal static List<List<IntPoint>> Minkowski(List<IntPoint> pattern, List<IntPoint> path, bool IsSum, bool IsClosed)
			{
				return null;
			}

			public static List<List<IntPoint>> MinkowskiSum(List<IntPoint> pattern, List<IntPoint> path, bool pathIsClosed)
			{
				return null;
			}

			private static List<IntPoint> TranslatePath(List<IntPoint> path, IntPoint delta)
			{
				return null;
			}

			public static List<List<IntPoint>> MinkowskiSum(List<IntPoint> pattern, List<List<IntPoint>> paths, bool pathIsClosed)
			{
				return null;
			}

			public static List<List<IntPoint>> MinkowskiDiff(List<IntPoint> poly1, List<IntPoint> poly2)
			{
				return null;
			}

			public static List<List<IntPoint>> PolyTreeToPaths(PolyTree polytree)
			{
				return null;
			}

			internal static void AddPolyNodeToPaths(PolyNode polynode, NodeType nt, List<List<IntPoint>> paths)
			{
			}

			public static List<List<IntPoint>> OpenPathsFromPolyTree(PolyTree polytree)
			{
				return null;
			}

			public static List<List<IntPoint>> ClosedPathsFromPolyTree(PolyTree polytree)
			{
				return null;
			}
		}

		public class ClipperOffset
		{
			private List<List<IntPoint>> m_destPolys;

			private List<IntPoint> m_srcPoly;

			private List<IntPoint> m_destPoly;

			private List<DoublePoint> m_normals;

			private double m_delta;

			private double m_sinA;

			private double m_sin;

			private double m_cos;

			private double m_miterLim;

			private double m_StepsPerRad;

			private IntPoint m_lowest;

			private PolyNode m_polyNodes;

			private const double two_pi = Math.PI * 2.0;

			private const double def_arc_tolerance = 0.25;

			public double ArcTolerance { get; set; }

			public double MiterLimit { get; set; }

			public ClipperOffset(double miterLimit = 2.0, double arcTolerance = 0.25)
			{
			}

			public void Clear()
			{
			}

			internal static long Round(double value)
			{
				return 0L;
			}

			public void AddPath(List<IntPoint> path, JoinType joinType, EndType endType)
			{
			}

			public void AddPaths(List<List<IntPoint>> paths, JoinType joinType, EndType endType)
			{
			}

			private void FixOrientations()
			{
			}

			internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2)
			{
				return default(DoublePoint);
			}

			private void DoOffset(double delta)
			{
			}

			public void Execute(ref List<List<IntPoint>> solution, double delta)
			{
			}

			public void Execute(ref PolyTree solution, double delta)
			{
			}

			private void OffsetPoint(int j, ref int k, JoinType jointype)
			{
			}

			internal void DoSquare(int j, int k)
			{
			}

			internal void DoMiter(int j, int k, double r)
			{
			}

			internal void DoRound(int j, int k)
			{
			}
		}

		private class ClipperException : Exception
		{
			public ClipperException(string description)
			{
			}
		}
	}
}
