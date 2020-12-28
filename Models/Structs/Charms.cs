using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using SramFormat.SoE.Models.Enums;

namespace SramFormat.SoE.Models.Structs
{
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Charms
	{
		public byte Byte1;
		public byte Byte2;
		public byte Byte3;

		public uint Value3Byte => BitConverter.ToUInt32(new[] { Byte1, Byte2, Byte3, byte.MinValue });

		public Charm EnumValue
		{
			get => (Charm)Value3Byte;
			set 
			{
				var bytes = BitConverter.GetBytes((uint)value);

				(Byte1, Byte2, Byte3) = (bytes[1], bytes[2], bytes[3]);
			}
		}

		public override string ToString() => EnumValue.ToString();
	}
}