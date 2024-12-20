using Femur;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class PlayerTracker : MonoBehaviour
{
	private CanvasGroup group;

	public Actor player;

	public Transform track;

	public RectTransform CanvasRect;

	private Camera Cam;

	private RectTransform thisRect;

	public Graphic[] ColorThese;

	public Transform spin;

	private void Start()
	{
	}

	public void Set(Actor bpi, Canvas canvas)
	{
	}

	private void Update()
	{
	}
}
