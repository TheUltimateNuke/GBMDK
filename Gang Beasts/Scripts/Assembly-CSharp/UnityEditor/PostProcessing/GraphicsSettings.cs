using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.PostProcessing
{
	public class GraphicsSettings : ScriptableObject
	{
		public enum TextureQualitySetting
		{
			Low = 0,
			Medium = 1,
			High = 2
		}

		public enum URPAntialiasingSetting
		{
			Off = 0,
			FXAA = 1,
			SMAALow = 2,
			SMAAMedium = 3,
			SMAAHigh = 4
		}

		public enum ShadowSetting
		{
			Off = 0,
			Lowest = 1,
			Low = 2,
			Medium = 3,
			High = 4
		}

		public enum ScreenSpaceReflectionSetting
		{
			Off = 0,
			Low = 1,
			High = 2
		}

		public TextureQualitySetting TextureQuality;

		public bool AnisotropicFiltering;

		public URPAntialiasingSetting PostAntialiasing;

		public bool VSync;

		public int FramerateCap;

		public ShadowSetting Shadows;

		public bool AmbientOcclusion;

		public ScreenSpaceReflectionSetting ScreenSpaceReflection;

		public bool Grain;

		public bool DepthOfField;

		public bool Bloom;

		public bool ChromaticAberration;

		public bool Vignette;

		public static bool operator ==(GraphicsSettings a, GraphicsSettings b)
		{
			return false;
		}

		public static bool operator !=(GraphicsSettings a, GraphicsSettings b)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public VolumeProfile GetPostProcessingProfile()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
