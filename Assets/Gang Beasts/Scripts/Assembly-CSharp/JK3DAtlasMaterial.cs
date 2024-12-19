using System;
using UnityEngine;

[Serializable]
public class JK3DAtlasMaterial
{
	public string atlasName;

	public string atlasPath;

	public Material staticMat;

	public Material dynamicMat;

	public bool isLightmapped;
}
