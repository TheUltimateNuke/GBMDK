using System.Collections.Generic;
using CoreNet.Model;
using CoreNet.Objects;
using UnityEngine;

namespace CoreNet.Utils
{
	public class NetDebugUI : MonoBehaviour
	{
		protected NetModel _Model;

		protected List<NetMember> _Members;

		protected GUIStyle _MemberStyle;

		public void Awake()
		{
		}

		private void OnMemberAdded(NetMember member)
		{
		}

		private void OnMemberUpdated(NetMember member)
		{
		}

		private void OnMemberRemoved(NetMember member)
		{
		}

		private void OnGUI()
		{
		}

		private void Draw()
		{
		}

		private void ListMember(NetMember member)
		{
		}

		protected virtual void ListPlayers(NetMember member)
		{
		}
	}
}
