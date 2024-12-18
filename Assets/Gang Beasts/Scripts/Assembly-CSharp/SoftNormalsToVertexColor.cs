using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class SoftNormalsToVertexColor : MonoBehaviour
{
	public enum Method
	{
		Simple = 0,
		AngularDeviation = 1
	}

	public Method method;

	public bool generateOnAwake;

	public bool generateNow;

	private void OnDrawGizmos()
	{
	}

	private void Awake()
	{
	}

	private void TryGenerate()
	{
	}

	private void Generate(Mesh m)
	{
	}
}
