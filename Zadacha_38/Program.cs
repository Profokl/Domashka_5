// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
#nullable disable
// Console.WriteLine("Введите числа через запятую:");
// string arr = Console.ReadLine();
// string[] a = arr.Split(",");

// int[] GetArray(string[] tmp)
// {

//     int len = tmp.Length;
//     int[] newArr = new int[len];
//     int i = 0;
//     for (i = 0; i < len; i++)
//     {
//         newArr[i] = Convert.ToInt32(tmp[i].ToString());
//     }
//     return newArr;
// }

// int DifMinMax(int[] array)
// {
//     int dif = 0;
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int min = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[min])
//             {
//                 min = j;
//             }
//         }
//         int temp = array[i];
//         array[i] = array[min];
//         array[min] = temp;
//     }

//     dif = array[array.Length - 1] - array[0];
//     return dif;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
// }

// int[] array = GetArray(a);
// DifMinMax(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Результат: {DifMinMax(array)}");


// Альтернативное решение через отдельное нахождение min&max

Console.WriteLine("Введите числа через запятую:");
string arr = Console.ReadLine();
string[] a = arr.Split(",");

int[] GetArray(string[] tmp)
{

    int len = tmp.Length;
    int[] newArr = new int[len];
    int i = 0;
    for (i = 0; i < len; i++)
    {
        newArr[i] = Convert.ToInt32(tmp[i].ToString());
    }
    return newArr;
}

int GetMin(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]<min)
        {
            min=arr[i];
        }
    }
    return min;
}

int GetMax(int[]arroy)
{
    int max = arroy[0];
    for(int i = 1;i<arroy.Length;i++)
    {
        if (arroy[i]>max)
        {
            max=arroy[i];
        }
    }
    return max;
}
int[] array = GetArray(a);
int diff = GetMax(array)-GetMin(array);
Console.WriteLine($"разница между максимальным и минимальным: {diff}");


