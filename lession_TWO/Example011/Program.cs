int[] array = { 50, 1, 2, 66, 88, 0, 9, 10 };

int n = array.Length;
int find = 10;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}