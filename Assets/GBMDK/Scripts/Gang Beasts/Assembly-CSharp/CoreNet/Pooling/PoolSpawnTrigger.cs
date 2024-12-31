using System.Collections.Generic;
using TypeReferences;
using UnityEngine;

namespace CoreNet.Pooling
{
	[RequireComponent(typeof(Collider))]
	public class PoolSpawnTrigger : MonoBehaviour
	{
		[SerializeField]
		private PoolSpawner TargetSpawner;

		[ClassExtends(typeof(MonoBehaviour))]
		[SerializeField]
		private ClassTypeReference DesiredComponent;

		[SerializeField]
		private float RepeatTime;

		private List<Component> OverlappingComponent;

		private float repeatTimer;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void Update()
		{
		}
	}
}
