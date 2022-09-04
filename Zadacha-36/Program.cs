// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[i] = random.Next(-100, 101);
    }
    return array;
}
int[] array = FillArray(n);

int GetOddIndex(int[] arr)
{
    int sumOdd = 0;
    int i = 0;
    int len = arr.Length;
    for (i = 0; i < len; i++)
    {
        if (i % 2 != 0)
        {
            sumOdd += arr[i];

        }
    }
    return sumOdd;
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

int result = GetOddIndex(array);

PrintArray(array);
Console.WriteLine();
Console.WriteLine(result);
