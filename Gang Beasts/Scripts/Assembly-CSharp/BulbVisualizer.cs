using UnityEngine;

public class BulbVisualizer : MonoBehaviour
{
	public Material[] bulbMaterials;

	public float brightnessMultiplier;

	public float flashTrigger;

	public float colourTrigger;

	public bool useBuffer;

	public Color[] colors;

	private int[] colorIndex;

	private void Start()
	{
	}

	private void BulbUpdate()
	{
	}
}
