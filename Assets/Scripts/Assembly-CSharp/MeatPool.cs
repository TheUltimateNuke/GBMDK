using UnityEngine;

public class MeatPool : MonoBehaviour
{
	public Mesh thisMesh;

	public SkinnedMeshRenderer thisRenderer;

	public float blendSpeed;

	private int lastBlendTarget;

	private int currentBlendTarget;

	private float currentBlendAmount;

	private float lastBlendAmount;

	private void Update()
	{
	}
}
