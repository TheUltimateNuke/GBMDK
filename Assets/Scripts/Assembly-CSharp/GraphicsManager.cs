using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using GB.Data.Loading;
using GB.Setup;
using UnityEditor.PostProcessing;
using UnityEngine;

public class GraphicsManager : MonoBehaviour, IDeferredActivator
{
	public class SavedSettings
	{
		public bool Fullscreen { get; set; }

		public int ScreenWidth { get; set; }

		public int ScreenHeight { get; set; }

		public GraphicsSettings Graphics { get; set; }

		public static bool operator ==(SavedSettings a, SavedSettings b)
		{
			return false;
		}

		public static bool operator !=(SavedSettings a, SavedSettings b)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public static SavedSettings Clone(SavedSettings source)
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	private static GraphicsManager _instance;

	private GraphicsTracker _tracker;

	private const string _fpsCapKey = "-fpscap";

	private static FieldInfo MainLightCastShadows_FieldInfo;

	private static FieldInfo MainLightShadowmapResolution_FieldInfo;

	private static FieldInfo AdditionalLightCastsShadows_FieldInfo;

	private static FieldInfo AdditionalLightShadowmapResolution_FieldInfo;

	[SerializeField]
	private ResourceCache _resources;

	public SavedSettings settings;

	private bool m_AppliedSettings;

	public static GraphicsManager Instance => null;

	public IDataCache Resources => null;

	public event Action<GraphicsSettings> GFXSettingsUpdate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void Awake()
	{
	}

	public void BeginDeferredActivation()
	{
	}

	public bool HasFinishedDeferredActivation()
	{
		return false;
	}

	private void OnDestroy()
	{
	}

	private SavedSettings DefaultSettings()
	{
		return null;
	}

	private void SetupURPFields()
	{
	}

	public void LoadSettings()
	{
	}

	public void PrepSaveSettings()
	{
	}

	public void SaveSettings()
	{
	}

	public void SaveSettings(SavedSettings newSettings)
	{
	}

	public void ResetSettings(bool save = true)
	{
	}

	public void ReapplySettings()
	{
	}

	public void ApplySettings(SavedSettings newSettings)
	{
	}

	public GraphicsSettings GetSettingsDataForQuality(int qualityValue)
	{
		return null;
	}
}
