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
    Console.Write($"Ваше множество: [{string.Join(", ", array)}]");
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
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = GetArray(InputNumber("Введите длину множества: "), 100, 999);
PrintArray(array);
Console.WriteLine(EvenNumbers(array));
