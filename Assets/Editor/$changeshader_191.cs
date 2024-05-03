using UnityEngine;
using UnityEditor;

public class ChangeShader : ScriptableWizard {
	public Shader replacementShader;
	
	[MenuItem ("GameObject/Change Shaders...")]
	static void CreateWizard() {
		ScriptableWizard.DisplayWizard(	"Change Shaders",
										typeof(ChangeShader),
										"Change Selected");
	}
	
	void OnWizardCreate() {
		Transform[] transforms = Selection.transforms;
		
		foreach (Transform transform in transforms)
			ChangeShadersRecursively(transform);
	}
	
	void ChangeShadersRecursively(Transform transform) {
		if (transform.GetComponent<Renderer>())
			foreach (Material material in transform.GetComponent<Renderer>().sharedMaterials)
				material.shader = replacementShader;
		foreach (Transform child in transform)
			ChangeShadersRecursively(child);
	}
	
	void OnWizardUpdate() {
		helpString = (replacementShader) ? "" : "Please choose a shader";
	}
}
