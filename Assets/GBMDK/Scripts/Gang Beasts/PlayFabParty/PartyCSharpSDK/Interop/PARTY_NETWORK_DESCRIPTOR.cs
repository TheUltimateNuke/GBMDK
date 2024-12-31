using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PartyCSharpSDK.Interop
{
	internal struct PARTY_NETWORK_DESCRIPTOR
	{
		[StructLayout(LayoutKind.Sequential, Size = 37)]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _003CnetworkIdentifier_003Ee__FixedBuffer
		{
			public byte FixedElementField;
		}

		[StructLayout(LayoutKind.Sequential, Size = 20)]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _003CregionName_003Ee__FixedBuffer
		{
			public byte FixedElementField;
		}

		[StructLayout(LayoutKind.Sequential, Size = 301)]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _003CopaqueConnectionInformation_003Ee__FixedBuffer
		{
			public byte FixedElementField;
		}

		private unsafe fixed byte networkIdentifier[37];

		private unsafe fixed byte regionName[20];

		private unsafe fixed byte opaqueConnectionInformation[301];

		internal string GetNetworkIdentifier()
		{
			return null;
		}

		internal string GetRegionName()
		{
			return null;
		}

		internal byte[] GetOpaqueConnectionInformation()
		{
			return null;
		}

		internal PARTY_NETWORK_DESCRIPTOR(PartyCSharpSDK.PARTY_NETWORK_DESCRIPTOR publicObject)
		{
			
		}
	}
}
