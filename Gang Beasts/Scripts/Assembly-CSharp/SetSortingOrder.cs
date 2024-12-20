using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class SetSortingOrder : MonoBehaviour
{
	public int sortOrder;

	private void OnValidate()
	{
	}
}
