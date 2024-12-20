using UnityEditor.PostProcessing;
using UnityEngine;
using UnityEngine.Rendering;

namespace GB.Environment.PostProcessing
{
	public class GlobalPostProcessController : MonoBehaviour
	{
		[SerializeField]
		private Volume connectedVolume;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void SettingsUpdate(UnityEditor.PostProcessing.GraphicsSettings newSettings)
		{
		}
	}
}
