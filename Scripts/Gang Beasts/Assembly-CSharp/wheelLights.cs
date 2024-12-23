using UnityEngine;

public class wheelLights : MonoBehaviour
{
	public float tick;

	public float lightsCycleStep;

	public float patternCycleStep;

	public bool colourCycle;

	public Color colour;

	public float colourCycleStep;

	public float emission;

	public Material targetMaterial;

	private float currentLightsCycleStep;

	private float currentPatternCycleStep;

	private float currentColourCycleStep;

	private float offsetX;

	private float offsetY;

	private float colourStep;

	private Color tmpColour;

	private bool directionFlip;

	private bool updateMaterial;

	private void Start()
	{
	}

	private void Tick()
	{
	}

	private void CyclePattern()
	{
	}

	private void CycleLights()
	{
	}

	private void CycleColour()
	{
	}
}
