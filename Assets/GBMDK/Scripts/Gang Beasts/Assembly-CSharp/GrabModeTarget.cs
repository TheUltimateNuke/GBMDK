using System.Collections.Generic;
using Femur;
using UnityEngine;

public class GrabModeTarget : MonoBehaviour
{
	public Dictionary<Actor, List<Collider>> partsInside;

	public Transform AttentionLocation;

	private Material[] materials;

	private Color[] materialOriginalColors;

	private Color targetColor;

	public Color currentColor;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void OnTriggerEnter(Collider col)
	{
	}

	public void OnTriggerExit(Collider col)
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Enabled()
	{
	}

	public Vector3 GetAttentionPosition()
	{
		return default(Vector3);
	}
}
