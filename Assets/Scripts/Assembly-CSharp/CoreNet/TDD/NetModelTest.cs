using CoreNet.Model;
using CoreNet.Objects;
using UnityEngine;

namespace CoreNet.TDD
{
	[RequireComponent(typeof(NetModel))]
	public class NetModelTest : MonoBehaviour
	{
		public const string INT_KEY_1 = "INT_KEY_1";

		public const string INT_KEY_2 = "INT_KEY_2";

		public const string NET_COLLECTION_INT = "NET_COLLECTION_INT";

		private NetModel _Model;

		private bool _Server;

		private float _LastUpdate;

		private bool _Flip;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void StartClientTest()
		{
		}

		public void StartServerTest()
		{
		}

		private void OnInt1Changed(NetInt netInt)
		{
		}

		private void OnInt2Changed(NetInt netInt)
		{
		}

		private void OnIntCollectionAdd(NetInt netInt)
		{
		}

		private void OnIntCollectionUpdate(NetInt netInt)
		{
		}

		private void OnIntCollectionRemove(NetInt netInt)
		{
		}

		private void InitServerTest()
		{
		}

		private void RunServerCollectionTest()
		{
		}

		private void RunServerUpdates()
		{
		}

		private void RunServerItemTest()
		{
		}
	}
}
