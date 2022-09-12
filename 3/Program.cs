// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101);
}

int SelectMax(int[] array)
{
    int Max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > Max) 
            Max = array[i];
    return Max;
}

int SelectMin(int[] array)
{
    int Min = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < Min) 
            Min = array[i];
    return Min;
}

Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
InputArray(arr);
Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + (SelectMax(arr) - SelectMin(arr)));