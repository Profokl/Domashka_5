// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
#nullable disable
Console.WriteLine("Задайте размер массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int n);
if (!isNumber || n <= 0)
{
    Console.WriteLine("Введите целое положительное число");
    return;
}

int[] FillArray(int a)
{
    int[] array = new int[a];
    Random random = new Random();
    int i = 0;
    for (i = 0; i < a; i++)
    {
        array[i] = random.Next(101, 1000);
    }
    return array;
}

int[] array = FillArray(n);

int GetPositive(int[] arr)
{
    int count = 0;
    int i = 0;
    int len = arr.Length;
    for (i = 0; i < len; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count = count + 1;

        }
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }

    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int result = GetPositive(array);

PrintArray(array);
Console.WriteLine();
Console.WriteLine(result);
