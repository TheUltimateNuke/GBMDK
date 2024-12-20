using System.Collections.Generic;
using CoreNet.Components;
using CoreNet.Model;
using CoreNet.Objects;
using UnityEngine;

namespace CoreNet.Utils
{
	[RequireComponent(typeof(NetModel))]
	public class NetConnectionCleanup : NetComponent
	{
		public float testInterval;

		private float timer;

		private List<NetConnection> toRemove;

		private void Update()
		{
		}
	}
}
