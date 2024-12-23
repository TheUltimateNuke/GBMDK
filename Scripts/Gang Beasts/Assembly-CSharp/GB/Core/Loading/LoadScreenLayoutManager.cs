using System;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

namespace GB.Core.Loading
{
	public class LoadScreenLayoutManager : MonoBehaviour
	{
		[Serializable]
		public struct ImageCarrier
		{
			public LayoutElement sizer;

			public RawImage image;
		}

		[SerializeField]
		public LocalizeStringEvent[] textFields;

		private TextMeshProUGUI[] textMeshes;

		[SerializeField]
		public ImageCarrier[] imageFields;

		public void ClearLayout()
		{
		}

		public bool ApplyText(int point, string text)
		{
			return false;
		}

		public bool ApplyTexture(int point, Texture texture)
		{
			return false;
		}

		private void Start()
		{
		}
	}
}
