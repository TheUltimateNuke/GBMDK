using UnityEngine;

namespace CoreNet.Utils.Animation
{
	[RequireComponent(typeof(TextMesh))]
	public class TextSwapOnControllerType : MonoBehaviour
	{
		public string xBoxControllerText;

		public string keyboardMouseText;

		private TextMesh textMesh;

		private void Start()
		{
		}
	}
}
