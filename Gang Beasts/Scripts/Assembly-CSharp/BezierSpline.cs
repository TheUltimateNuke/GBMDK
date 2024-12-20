using UnityEngine;

[ExecuteInEditMode]
public class BezierSpline : MonoBehaviour
{
	[SerializeField]
	private Vector3[] points;

	[SerializeField]
	private BezierControlPointMode[] modes;

	[SerializeField]
	private bool loop;

	public bool Loop
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int ControlPointCount => 0;

	public int CurveCount => 0;

	public Vector3 GetControlPoint(int index)
	{
		return default(Vector3);
	}

	public void SetControlPoint(int index, Vector3 point)
	{
	}

	public BezierControlPointMode GetControlPointMode(int index)
	{
		return default(BezierControlPointMode);
	}

	public void SetControlPointMode(int index, BezierControlPointMode mode)
	{
	}

	private void EnforceMode(int index)
	{
	}

	public Vector3 GetPoint(float t)
	{
		return default(Vector3);
	}

	public Vector3 GetVelocity(float t)
	{
		return default(Vector3);
	}

	public Vector3 GetDirection(float t)
	{
		return default(Vector3);
	}

	public void AddCurve()
	{
	}

	public void Reset()
	{
	}

	private void Update()
	{
	}
}
