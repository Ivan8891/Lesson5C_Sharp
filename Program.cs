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
PrintArray(GetArray(InputNumber("Введите длину множества: "), InputNumber("Введите минимальное значение множества: "), InputNumber("Введите максимальное значение множества")));