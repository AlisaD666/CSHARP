Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine(x);
if (x % 7 == 0 && x % 23 == 0) Console.WriteLine("Число кратно 7 и 23");
else Console.WriteLine("Число не кратно 7 и 23");