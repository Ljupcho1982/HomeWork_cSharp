
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Gray;
Console.Title = "Practice number sizes and ranges";
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine($"\v");
Console.WriteLine($"Type \t Byte(s) of memory \t \t Min \t \t \t\t Max");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine($"sbyte \t {sizeof(sbyte)} \t \t \t \t {sbyte.MinValue} \t \t \t\t{sbyte.MaxValue}");
Console.WriteLine($"byte \t {sizeof(byte)} \t \t \t \t {byte.MinValue} \t \t \t\t{byte.MaxValue}");
Console.WriteLine($"short \t {sizeof(short)} \t \t \t \t {short.MinValue} \t \t\t{short.MaxValue}");
Console.WriteLine($"ushort \t {sizeof(ushort)} \t \t \t \t {ushort.MinValue} \t \t\t \t{ushort.MaxValue}");
Console.WriteLine($"int \t {sizeof(int)} \t \t \t \t {int.MinValue} \t \t\t{int.MaxValue}");
Console.WriteLine($"uint \t {sizeof(uint)} \t \t \t \t {uint.MinValue} \t \t\t \t{uint.MaxValue}");
Console.WriteLine($"long \t {sizeof(long)} \t \t \t \t {long.MinValue}\t\t{long.MaxValue}");
Console.WriteLine($"float \t {sizeof(float)} \t \t \t \t {float.MinValue}  \t        {float.MaxValue}");
Console.WriteLine($"double \t {sizeof(double)} \t \t \t \t {double.MinValue}       {double.MaxValue}");
Console.WriteLine($"decimal {sizeof(decimal)} \t \t \t\t {decimal.MinValue} {decimal.MaxValue}");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
