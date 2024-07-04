using System;
using System.ComponentModel;

namespace GB.Gamemodes
{
	[Flags]
	public enum GameModeEnum
	{
		[Description("GAMEMODE_NAME_MELEE")]
		Melee = 1,
		[Description("GAMEMODE_NAME_KOTH")]
		KingOfTheHill = 2,
		[Description("GAMEMODE_NAME_WAVES")]
		Waves = 4,
		[Description("GAMEMODE_NAME_CTF")]
		CaptureTheFlag = 8,
		[Description("GAMEMODE_NAME_FOOTBALL")]
		Football = 0x10,
		[Description("GAMEMODE_NAME_LOBBY")]
		Lobby = 0x20,
		[Description("GAMEMODE_NAME_GANG_MELEE")]
		GangMelee = 0x40,
		[Description("GAMEMODE_NAME_RUMBLE")]
		Rumble = 0x80,
		[Description("GAMEMODE_NAME_BIGFIGHT")]
		BigFight = 0x100
	}
}
