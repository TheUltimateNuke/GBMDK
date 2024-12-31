using System;
using System.Collections.Generic;
using UnityEngine;

namespace Costumes
{
	[Obsolete("No longer used. Previously was an unused member on CostumeCustomisation", true)]
	public class MaterialsColorChanger
	{
		private List<MaterialColorChanger> _materialsColorChanger;

		public List<MaterialColorChanger> MaterialsColorChangerList => null;

		public MaterialsColorChanger()
		{
		}

		public MaterialsColorChanger(List<MaterialColorChanger> materialColorChangers)
		{
		}

		public MaterialsColorChanger(List<Material> materials)
		{
		}

		public MaterialsColorChanger(string partialMatName, List<GameObject> gameObjects)
		{
		}

		public void AddMaterialsFromGameObjects(string partialMatName, List<GameObject> gameObjects)
		{
		}

		public void AddMaterialsFromGameObjects(string partialMatName, GameObject go, MaterialsFromGos materialsFromGos)
		{
		}

		public void SetMaterialsColor(Color color)
		{
		}

		public void PreviousMaterialsColor()
		{
		}

		public void RevertDefaultMaterialsColor()
		{
		}
	}
}
