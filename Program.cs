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
