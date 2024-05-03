using System.Collections;
using UnityEditor;
using UnityEngine.ResourceManagement.ResourceLocations;

/**
 * TreeNode.cs
 * Author: Luke Holland (http://lukeholland.me/)
 */

namespace TreeView {

	public class AssetTree 
	{
		
		private TreeNode<AssetData> _root;

		public AssetTree()
		{
			_root = new TreeNode<AssetData>(null);
		}

		public TreeNode<AssetData> Root { get { return _root; }}

		public void Clear()
		{
			_root.Clear();
		}

		public void AddAsset(IResourceLocation asset, string assetPath)
		{
			if(asset == null) return;
			

			var node = _root;
			
			int startIndex = 0, length = assetPath.Length;
			while(startIndex<length)
			{
				var endIndex  = assetPath.IndexOf('/', startIndex);
				var subLength = endIndex ==-1 ? length -startIndex : endIndex -startIndex;
				var directory = assetPath.Substring(startIndex, subLength);
				
				var pathNode = new AssetData(directory,asset, false);

				var child = node.FindInChildren(pathNode) ?? node.AddChild(pathNode);

				node = child;
				startIndex += subLength+1;
			}
		}

	}

	public class AssetData : ITreeIMGUIData
	{
		public readonly string            path;
		public readonly IResourceLocation asset;
		public          bool              isExpanded { get; set; }

		public AssetData(string path, IResourceLocation asset,  bool isExpanded)
		{
			this.path       = path;
			this.isExpanded = isExpanded;
			this.asset      = asset;
		}

		public override string ToString ()
		{
			return path;
		}

		public override int GetHashCode ()
		{
			return path.GetHashCode()+10;
		}

		public override bool Equals (object obj)
		{
			AssetData node = obj as AssetData;
			return node!=null && node.path==path;
		}

		public bool Equals(AssetData node)
		{
			return node.path==path;
		}

	}

}