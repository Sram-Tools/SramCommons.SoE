using System.Diagnostics;
using System.Runtime.InteropServices;
using SramCommons.Extensions;

namespace RosettaStone.Sram.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// Ingredients_Items_Armors_Ammo_FlyingMachine
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk19"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	public struct Chunk19
	{
		// Ingredients
		public Ingredients Ingredients; // [649|x289] :: (22 bytes)

		// Items
		public Items Items; // [671|x29F] :: (8 bytes)

		public Armors Armors; // [679|x2A7] :: (40 bytes)

		public BazookaAmmunitions BazookaAmmunitions; // [719|x2CF] :: (3 bytes)

		// Unknown 17
		// Note: contains market timer
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17A)]
		public byte[] Unknown17A; // [723|x2D3] :: (12 bytes) 

		// 00 = none, 01 = Windwalker, 02 = Escape Pod
		public byte FlyingMachineType; // [734|x2DE] :: (1 byte) 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = SramSizes.SaveSlot.Unknown17B)]
		public byte[] Unknown17B; // [735|x2DF] :: (7 bytes) 

		public override string ToString() => this.FormatAsString();
	}
}