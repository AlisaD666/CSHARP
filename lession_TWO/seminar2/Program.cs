Console.WriteLine("Введите два целых числа");
Console.WriteLine("Первое число: ");
int number_one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int number_two = Convert.ToInt32(Console.ReadLine());

if (number_one == number_two*number_two) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}