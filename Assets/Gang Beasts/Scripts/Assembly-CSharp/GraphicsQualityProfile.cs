using System;
using UnityEditor.PostProcessing;

[Serializable]
public class GraphicsQualityProfile
{
	public string SettingsName;

	public GraphicsSettings PC;

	public GraphicsSettings Mac;

	public GraphicsSettings Linux;

	public GraphicsSettings PS4;

	public GraphicsSettings XboxOne;

	public GraphicsSettings Switch;

	public GraphicsQualityProfile()
	{
	}

	public GraphicsQualityProfile(string name)
	{
	}
}
