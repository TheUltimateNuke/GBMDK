namespace CS.CorePlatform.Utils.Data
{
	public static class PlatformDataExtensions
	{
		public class EncryptionData
		{
			public string Uuid;

			public byte[] EncryptionKey;

			public uint EncryptionKeyLength;

			public byte[] HmacKey;

			public uint HmacKeyLength;

			public byte[] InitialisationVector;

			public uint InitialisationVectorLength;
		}

		public static void WriteMatchmakingEncryptionModel(DataWriter writer, EncryptionData encryptionData)
		{
		}

		public static EncryptionData ReadMatchmakingEncryptionModel(DataReader reader)
		{
			return null;
		}
	}
}
