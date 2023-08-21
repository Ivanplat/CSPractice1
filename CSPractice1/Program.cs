using static System.Console;

WriteLine($"{"Type",-10} {"Byte(s) of memory",-10} {"Min", 40} {"Max", 40}");
WriteLine("-------------------------------------------------------------------------------------------------------------------");
WriteLine($"{"sbyte",-10}   {sizeof(sbyte),-10}   {sbyte.MinValue,47}   {sbyte.MaxValue,40}");
WriteLine($"{"byte",-10}    {sizeof(byte),-10}    {byte.MinValue,47}    {byte.MaxValue,40}");
WriteLine($"{"short",-10}   {sizeof(short),-10}   {short.MinValue,47}   {short.MaxValue,40}");
WriteLine($"{"ushort",-10}  {sizeof(ushort),-10}  {ushort.MinValue,47}  {ushort.MaxValue,40}");
WriteLine($"{"int",-10}     {sizeof(int),-10}     {int.MinValue,47}     {int.MaxValue,40}");
WriteLine($"{"uint",-10}    {sizeof(uint),-10}    {uint.MinValue,47}    {uint.MaxValue,40}");
WriteLine($"{"long",-10}    {sizeof(long),-10}    {long.MinValue,47}    {long.MaxValue,40}");
WriteLine($"{"ulong",-10}   {sizeof(ulong),-10}   {ulong.MinValue,47}   {ulong.MaxValue,40}");
WriteLine($"{"float",-10}   {sizeof(float),-10}   {float.MinValue,47}   {float.MaxValue,40}");
WriteLine($"{"double",-10}  {sizeof(double),-10}  {double.MinValue,47}  {double.MaxValue,40}");
WriteLine($"{"decimal",-10} {sizeof(decimal),-10} {decimal.MinValue,47} {decimal.MaxValue,40}");
WriteLine("-------------------------------------------------------------------------------------------------------------------");