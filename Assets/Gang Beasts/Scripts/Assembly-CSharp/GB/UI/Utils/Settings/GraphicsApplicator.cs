using System.Collections.Generic;
using UnityEngine;

namespace GB.UI.Utils.Settings
{
	public class GraphicsApplicator : OptionsMenu
	{
		public enum QualitySetting
		{
			TextureQuality = 0,
			AnisotropicFiltering = 1,
			PostAntialiasing = 2,
			VSync = 3,
			FramerateCap = 4,
			Shadows = 5,
			AmbientOcclusion = 6,
			ScreenSpaceReflection = 7,
			Grain = 8,
			DepthOfField = 9,
			Bloom = 10,
			ChromaticAberration = 11,
			Vignette = 12
		}

		[SerializeField]
		private IntOptionHandler resolutionOptRef;

		[SerializeField]
		private IntOptionHandler screenModeOptRef;

		[SerializeField]
		private IntOptionHandler qualityOptRef;

		[SerializeField]
		private IntOptionHandler textureQualityOptRef;

		[SerializeField]
		private BoolOptionHandler anisotropicFilteringOptRef;

		[SerializeField]
		private IntOptionHandler postAntialiasingOptRef;

		[SerializeField]
		private BoolOptionHandler vsyncOptRef;

		[SerializeField]
		private IntOptionHandler framerateCapOptRef;

		[SerializeField]
		private IntOptionHandler shadowOptRef;

		[SerializeField]
		private BoolOptionHandler ambientOcclusionOptRef;

		[SerializeField]
		private IntOptionHandler screenSpaceReflectionsOptRef;

		[SerializeField]
		private BoolOptionHandler grainOptRef;

		[SerializeField]
		private BoolOptionHandler depthOfFieldOptRef;

		[SerializeField]
		private BoolOptionHandler bloomOptRef;

		[SerializeField]
		private BoolOptionHandler chromaticAbberationOptRef;

		[SerializeField]
		private BoolOptionHandler vignetteOptRef;

		private List<Vector2Int> screenResolutionLookup;

		private GraphicsManager.SavedSettings customisedSettings;

		private bool _blockUpdateSettings;

		private bool allowSettingToCustom;

		private void InitResolutionDictionaries()
		{
		}

		private void UpdateResolutionUI()
		{
		}

		private int LookupResolutionCodes(int width, int height)
		{
			return 0;
		}

		public void Initialise()
		{
		}

		private void RedrawUI()
		{
		}

		public void UpdateFullscreenSetting()
		{
		}

		public void UpdateResolutionSettings()
		{
		}

		public void UpdateQualitySetting()
		{
		}

		public void UpdateSetting()
		{
		}

		private void CheckQualityPreset()
		{
		}

		public override void RejectSettings()
		{
		}

		public override void SetupSettings()
		{
		}

		public override void ApplySettings()
		{
		}

		public override bool HaveSettingsChanged()
		{
			return false;
		}
	}
}
