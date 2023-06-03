int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] GetArray (int length, int min, int max)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Ваше множество: [{string.Join(", ", array)}]");
}

string EvenNumbers(int[] array)
{
    int res = 0;
    int count = 0;
    foreach(int i in array)
    {
        res = i % 2;
        if( res == 0 ) count ++;
    }
    return $"Колличество четных чисел в массиве: {count}.";
}
int CountNumbers(int[] array)
{
    int count = 0;
    foreach( int i in array)
    {
        if ( i >= 10 && i <= 99 ) count++;
    }
    return count;
}
int SumNoEvenIndex(int[] array)
{
    int even = 0;
    int sum = 0;
    for( int i = 0; i < array.Length; i++)
    {
        even = i % 2;
        if ( even != 0 ) sum += array[i];
    }
    return sum;
}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int[] array34 = GetArray(InputNumber("Введите длину множества: "), 100, 999);
// PrintArray(array34);
// Console.WriteLine(EvenNumbers(array34));

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// int[] array35 = GetArray(123, 0, 123);
// PrintArray(array35);
// Console.WriteLine($"Количество элементов массива в отрезке [10, 99]: {CountNumbers(array35)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array36 = GetArray(InputNumber("Введите длину множества: "), InputNumber("Введите минимальное значение: "), InputNumber("Введите максимальное значение: "));
PrintArray(array36);
Console.WriteLine($"Сумма всех элементов массива стоящих на нечетных позициях {SumNoEvenIndex(array36)}");