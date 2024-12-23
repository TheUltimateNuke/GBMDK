using System;
using System.ComponentModel;

namespace UnityEngine.Networking
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DisallowMultipleComponent]
	[AddComponentMenu("Network/NetworkTransformVisualizer")]
	[RequireComponent(typeof(NetworkTransform))]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkTransformVisualizer : NetworkBehaviour
	{
		[Tooltip("The prefab to use for the visualization object.")]
		[SerializeField]
		private GameObject m_VisualizerPrefab;

		private NetworkTransform m_NetworkTransform;

		private GameObject m_Visualizer;

		private static Material s_LineMaterial;

		public GameObject visualizerPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void OnStartClient()
		{
		}

		public override void OnStartLocalPlayer()
		{
		}

		private void OnDestroy()
		{
		}

		[ClientCallback]
		private void FixedUpdate()
		{
		}

		private void OnRenderObject()
		{
		}

		private void DrawRotationInterpolation()
		{
		}

		private static void CreateLineMaterial()
		{
		}
	}
}
