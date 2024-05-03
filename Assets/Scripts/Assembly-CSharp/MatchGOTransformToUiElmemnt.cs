using UnityEngine;
using UnityEngine.UI;

public class MatchGOTransformToUiElmemnt : MonoBehaviour
{
	public Camera SourceCamera;

	public Camera TargetCamera;

	public float YOffset;

	public RectTransform MatchPos;

	public CanvasScaler MatchScale;

	public GameObject TargetGameObject;

	private Vector2 _lastAnchoredPos;

	private float _lastScalerHeight;

	private float _zOffset;

	private Vector2 _screenPos;

	private RectTransform _scalerRectTransform;

	public void Awake()
	{
	}

	public void FixedUpdate()
	{
	}

	public void UpdateGoOffset()
	{
	}
}
