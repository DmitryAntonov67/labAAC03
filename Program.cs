using System.Text;

int number = 305419896;
Console.WriteLine($"Число: {number}");
Console.WriteLine($"В hex: 0x{number: x8}");
Console.WriteLine($"Little-endian:{BitConverter.IsLittleEndian}");
byte[] numberBytes = BitConverter.GetBytes(number);
Console.WriteLine("байты числа:");
Console.WriteLine(BitConverter.ToString(numberBytes));
string text = "hello";
Console.WriteLine();
Console.WriteLine($"Тест:{text}");
byte[] textBytes = Encoding.UTF8.GetBytes(text);
Console.WriteLine("Байты текста UTF-8:");
Console.WriteLine(BitConverter.ToString(textBytes));

string text2 = "Привет";
byte[] textBytes2 = Encoding.UTF8.GetBytes(text2);
Console.WriteLine();
Console.WriteLine($"текст:{text2}");
Console.WriteLine($"количество символов:{text2.Length}");
Console.WriteLine($"количество байтов UTf-8:{textBytes2.Length}");
Console.WriteLine($"Байты:{BitConverter.ToString(textBytes2)}");

string english = "A";
string russian = "А";

byte[] englishBytes = Encoding.UTF8.GetBytes(english);
byte[] russianBytes = Encoding.UTF8.GetBytes(russian);
Console.WriteLine($"A:{BitConverter.ToString(englishBytes)}");
Console.WriteLine($"А:{BitConverter.ToString(russianBytes)}");

string text3 = "Привет";
byte[] bytes = Encoding.UTF8.GetBytes(text3);
string restored = Encoding.UTF8.GetString(bytes);
Console.WriteLine($"Исходная строка: {text3}");
Console.WriteLine($"Восстановленная: {restored}");

int number2 = 123456789;
byte[] bytes2 = BitConverter.GetBytes(number2);
int restored2 = BitConverter.ToInt32(bytes2, 0);
Console.WriteLine($"Исходное число: {number2}");
Console.WriteLine($"Восстановление:{restored2}");
Console.WriteLine($"Байты:{BitConverter.ToString(bytes2)}");

byte[] data = { 0x41, 0x42, 0x43 };
Console.WriteLine($"Байты: {BitConverter.ToString(data)}");
Console.WriteLine($"Как текст UTF-8: {Encoding.UTF8.GetString(data)}");
