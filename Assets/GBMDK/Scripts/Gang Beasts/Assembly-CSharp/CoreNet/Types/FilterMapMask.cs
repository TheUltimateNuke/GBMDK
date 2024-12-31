using System;

namespace CoreNet.Types
{
	[Flags]
	public enum FilterMapMask
	{
		NONE = 0,
		Billboard = 1,
		Blimp = 2,
		Buoy = 4,
		Chute = 8,
		Containers = 0x10,
		Elevators = 0x20,
		Fans = 0x40,
		Girder = 0x80,
		Gondola = 0x100,
		Grind = 0x200,
		Incinerator = 0x400,
		Ring = 0x800,
		Subway = 0x1000,
		Towers = 0x2000,
		Trucks = 0x4000,
		Wheel = 0x8000,
		ALL = 0xFFFF
	}
}
