using System.Collections.Generic;
using UnityEngine;

public class RopeInterface : MonoBehaviour
{
	public static string SEGMENT_PATH;

	public static string HANDLE_PATH;

	public int SegmentCount;

	public int SegmentSides;

	public float SegmentOverlap;

	public float SegmentWidthRatio;

	public int HandlesPerSegment;

	public Material Material;

	public GameObject Template;

	public GameObject EndsTemplate;

	public RopeAnchor RopeStart;

	public RopeAnchor RopeEnd;

	private float _TotalLength;

	private Vector3 _SegmentInterval;

	private List<Rigidbody> _Rigidbodies;

	public void Start()
	{
	}

	public void BuildRope()
	{
	}

	public void DestroyRope()
	{
	}

	public void ResetRigidbodies()
	{
	}

	public void SetKinematic(bool isKinematic)
	{
	}

	private void Init()
	{
	}

	private void CreateSegments()
	{
	}

	private void SetRopeSegmentConnections(GameObject current, GameObject prev)
	{
	}

	private void TryLoadFromTemplate(GameObject segmentGO, GameObject template)
	{
	}

	private bool TemplateIsValid()
	{
		return false;
	}

	private GameObject CreateSegment(int index)
	{
		return null;
	}

	private void AddHandles(Transform childSeg)
	{
	}

	private void DecorateSegment(Transform childSeg, int index)
	{
	}

	private bool RopeAnchorsSetUp()
	{
		return false;
	}

	private void Debug_LoadSegmentRigidbodies()
	{
	}
}
