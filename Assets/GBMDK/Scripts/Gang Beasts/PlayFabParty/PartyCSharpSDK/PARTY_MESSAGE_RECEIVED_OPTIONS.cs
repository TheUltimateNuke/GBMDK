namespace PartyCSharpSDK
{
	public enum PARTY_MESSAGE_RECEIVED_OPTIONS : uint
	{
		PARTY_MESSAGE_RECEIVED_OPTIONS_NONE = 0u,
		PARTY_MESSAGE_RECEIVED_OPTIONS_GUARANTEED_DELIVERY = 1u,
		PARTY_MESSAGE_RECEIVED_OPTIONS_SEQUENTIAL_DELIVERY = 2u,
		PARTY_MESSAGE_RECEIVED_OPTIONS_REQUIRED_FRAGMENTATION = 4u
	}
}