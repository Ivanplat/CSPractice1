using static System.Console;

WriteLine($"{"Type",-10} {"Byte(s) of memory",-10} {"Min", 40} {"Max", 40}");
WriteLine("-------------------------------------------------------------------------------------------------------------------");
WriteLine($"{"sbyte",-10}{sizeof(sbyte),-10}{sbyte.MinValue,49}{sbyte.MaxValue,40}");
WriteLine($"{"byte",-10}{sizeof(byte),-10}{byte.MinValue,49}{byte.MaxValue,40}");
WriteLine($"{"short",-10}{sizeof(short),-10}{short.MinValue,49}{short.MaxValue,40}");
WriteLine($"{"ushort",-10}{sizeof(ushort),-10}{ushort.MinValue,49}{ushort.MaxValue,40}");
WriteLine($"{"int",-10}{sizeof(int),-10}{int.MinValue,49}{int.MaxValue,40}");
WriteLine($"{"uint",-10}{sizeof(uint),-10}{uint.MinValue,49}{uint.MaxValue,40}");
WriteLine($"{"long",-10}{sizeof(long),-10}{long.MinValue,49}{long.MaxValue,40}");
WriteLine($"{"ulong",-10}{sizeof(ulong),-10}{ulong.MinValue,49}{ulong.MaxValue,40}");
WriteLine($"{"float",-10}{sizeof(float),-10}{float.MinValue,49}{float.MaxValue,40}");
WriteLine($"{"double",-10}{sizeof(double),-10}{double.MinValue,49}{double.MaxValue,40}");
WriteLine($"{"decimal",-10}{sizeof(decimal),-10}{decimal.MinValue,49}{decimal.MaxValue,40}");
WriteLine("-------------------------------------------------------------------------------------------------------------------");