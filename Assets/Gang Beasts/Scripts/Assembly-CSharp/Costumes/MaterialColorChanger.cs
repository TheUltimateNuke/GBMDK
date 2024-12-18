using UnityEngine;

namespace Costumes
{
	public class MaterialColorChanger
	{
		private Material _locaMaterial;

		private Color _localColor;

		private Color _previousColor;

		private Color _originalColor;

		public Material LocalMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color LocalColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color PreviousColor => default(Color);

		public Color OriginalColor => default(Color);

		public MaterialColorChanger(Material localMaterial)
		{
		}
	}
}
