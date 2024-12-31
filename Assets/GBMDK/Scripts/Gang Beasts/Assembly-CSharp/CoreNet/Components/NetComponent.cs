using CoreNet.Model;
using UnityEngine;

namespace CoreNet.Components
{
	[RequireComponent(typeof(NetModel))]
	public class NetComponent : MonoBehaviour
	{
		protected NetModel Model;

		protected void Awake()
		{
		}
	}
}
