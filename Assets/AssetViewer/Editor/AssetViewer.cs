using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

/**
 * TreeNode.cs
 * Author: Luke Holland (http://lukeholland.me/)
 */

namespace TreeView {
	public class AssetViewer : EditorWindow {
		[MenuItem("Tools/Asset Viewer")]
		private static void CreateEditorWindow() {
			EditorWindow.GetWindow<AssetViewer>("Asset Viewer");
		}

		private AssetTree                             assetTree;
		private AssetTreeIMGUI                         assetTreeGUI;
		private Vector2                                scrollPosition;
		private string                                 searchString;
		private AsyncOperationHandle<IResourceLocator> catalogHandle;
		private List<IResourceLocation>                assetKeys = new();
		private UnityEngine.Object                     loadedAsset;
		private bool                                   isLoadingCatalog        = false;
		private bool                                   isCatalogLoadSucessfull = true;

		private string catalogPath =
			"C:\\Program Files (x86)\\Steam\\steamapps\\common\\BONELAB\\BONELAB_Steam_Windows64_Data\\StreamingAssets\\aa\\catalog.json";

		private string catalogError = "None :)";
		private string tempCatalog  = "";

		private List<(IResourceLocation, Type, string)> localCache = new List<(IResourceLocation, Type, string)>();


		protected void OnEnable() {
			// setup
			assetTree    = new AssetTree();
			assetTreeGUI = new AssetTreeIMGUI(assetTree.Root);

			// fill tree with example data
			searchString = "";
			Search(searchString);
		}

		protected void OnGUI() {
			GUILayout.Space(10f);

			GUILayout.Label("Select Catalog file:");

			GUILayout.BeginHorizontal();
			catalogPath = EditorGUILayout.TextField(catalogPath);

			if (GUILayout.Button("Browse", GUILayout.Width(80f))) {
				catalogPath = EditorUtility.OpenFilePanel("Select catalog file", catalogPath, "catalog.json");
			}

			GUILayout.EndHorizontal();

			GUILayout.Space(10f);

			GUILayout.BeginHorizontal();

			if (!isLoadingCatalog && GUILayout.Button("Refresh Asset List")) {
				UnloadAllStuff();
				LoadContentCatalog();
			}

			if (GUILayout.Button("Unload All Asset Bundles")) UnloadAllStuff();

			GUILayout.EndHorizontal();

			GUILayout.Space(10f);

			// draw search
			EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);

			EditorGUILayout.LabelField("Search:", EditorStyles.miniLabel, GUILayout.Width(40));

			EditorGUI.BeginChangeCheck();
			searchString =
				EditorGUILayout.TextField(searchString, EditorStyles.toolbarTextField, GUILayout.ExpandWidth(true));
			if (EditorGUI.EndChangeCheck()) {
				Search(searchString);
			}

			EditorGUILayout.EndHorizontal();

			switch (assetKeys.Count) {
				case 0 when !isLoadingCatalog && isCatalogLoadSucessfull:
					GUILayout.Label("No catalog loaded or empty catalog :/", EditorStyles.boldLabel);
					break;
				case 0 when !isLoadingCatalog && !isCatalogLoadSucessfull:
					GUILayout.Label("Failed to load the catalog: " + catalogError, EditorStyles.boldLabel);
					break;
				case 0 when isLoadingCatalog:
					GUILayout.Label("Loading catalog 👍", EditorStyles.boldLabel);
					break;
				default:
					// draw tree
					scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
					assetTreeGUI.DrawTreeLayout();
					EditorGUILayout.EndScrollView();
					break;
			}
		}
		
		void OnInspectorUpdate()
		{
			Repaint();
		}

		private void UnloadAllStuff() {
			assetTree.Clear();
			localCache.Clear();
			AssetBundle.UnloadAllAssetBundles(false);
		}

		private void Search(string query) {
			assetTree.Clear();

			var smolQuery = query.ToLower();


			foreach (var asset in localCache) {
				if (!asset.Item3.ToLower().Contains(smolQuery) && !asset.Item2.ToString().ToLower().Contains(smolQuery))
					continue;
				
				assetTree.AddAsset(asset.Item1, asset.Item3);
			}
		}

		private void LoadContentCatalog() {
			isLoadingCatalog = true;
			var catalogText    = File.ReadAllText(catalogPath);
			var catalogDirPath = Path.GetDirectoryName(catalogPath).Replace(@"\", @"\\");
			catalogText = catalogText.Replace("{UnityEngine.AddressableAssets.Addressables.RuntimePath}",
											  catalogDirPath)
									 .Replace("{SLZ.Marrow.MarrowSDK.RuntimeModsPath}", catalogDirPath);
			tempCatalog = Path.GetTempFileName();
			File.WriteAllText(tempCatalog, catalogText);
			catalogHandle = Addressables.LoadContentCatalogAsync(
				tempCatalog);
			catalogHandle.Completed += CatalogLoadCompleted;
		}

		private async void CatalogLoadCompleted(AsyncOperationHandle<IResourceLocator> handle) {
			if (handle.Status == AsyncOperationStatus.Succeeded) {
				var results = handle.Result;
				assetKeys.Clear();
				assetKeys.Capacity = results.Keys.Count();
				foreach (var key in results.Keys) {
					handle.Result.Locate(key, typeof(object), out var theStuff);
					assetKeys.AddRange(theStuff);
				}
			}
			else {
				isCatalogLoadSucessfull = false;
				isLoadingCatalog        = false;
				catalogError            = handle.OperationException.ToString();
				File.Delete(tempCatalog);
				Debug.LogError("Failed to load content catalog: " + handle.OperationException);
				return;
			}
			
			foreach (var asset in assetKeys) {
				//var assetGUID = GenerateGuidFromStringSeed(asset.InternalId);
				var assetPath = asset.InternalId;
				
				if (!assetPath.StartsWith("Assets")) {
					if(asset.ResourceType == typeof(IAssetBundleResource))
						continue;
					if (asset.ResourceType == typeof(SceneInstance)) {
						assetPath = "Unnamed Assets/" + asset.ResourceType + "/" + asset.InternalId;
						assetTree.AddAsset(asset, assetPath);
						localCache.Add((asset, asset.ResourceType, assetPath));
						continue;
					}


					if (asset.HasDependencies && asset.Dependencies.Count > 0) {
						if(asset.Dependencies[0].PrimaryKey.Contains("_previewmesh"))
							assetPath  = "Unnamed Assets/Preview Meshes/" + asset.Dependencies[0].PrimaryKey.Replace(".bundle", "");
						else assetPath = "Unnamed Assets/" + asset.Dependencies[0].PrimaryKey.Replace(".bundle", "");
					}
					else {
						assetPath = "Unnamed Assets/" + asset.ResourceType + "/" + asset.PrimaryKey;
					}
					assetTree.AddAsset(asset, assetPath);
					localCache.Add((asset, asset.ResourceType, assetPath));
				}
				else {
					assetTree.AddAsset(asset, assetPath);
					localCache.Add((asset, asset.ResourceType, assetPath));
				}
			}

			isLoadingCatalog = false;
			File.Delete(tempCatalog);
		}

		private void OnDestroy() {
			if (catalogHandle.IsValid()) {
				Addressables.Release(catalogHandle);
			}
		}
	}
}