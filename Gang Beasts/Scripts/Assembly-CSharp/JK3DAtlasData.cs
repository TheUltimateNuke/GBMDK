using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class JK3DAtlasData : ScriptableObject
{
	public List<Mesh> meshes;

	public Material staticMat;

	public Material dynamicMat;

	public Mesh GetMeshWithModelName(string name)
	{
		return null;
	}
}
