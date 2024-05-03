using System;
using Coatsink.Common;

[Serializable]
public class JK3DAtlasMaterials : ConstArray<JK3DAtlasMaterial>
{
	public JK3DAtlasMaterials(uint size)
		: base(0u)
	{
	}

	private JK3DAtlasMaterials()
		: base(0u)
	{
	}
}
