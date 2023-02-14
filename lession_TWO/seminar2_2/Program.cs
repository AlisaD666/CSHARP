Console.WriteLine("Введите число первое ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число второе ");
int y = int.Parse(Console.ReadLine());

if (x % y == 0) Console.WriteLine("Второе число кратно первому");
else
{
    Console.Write("Не кратно, остаток = ");
    Console.WriteLine(x % y);
}
