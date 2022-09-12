// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
       array[i] = new Random().Next(-99, 100);  
}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 !=0)
            sum = sum + array[i];
    return sum;
}

Console.WriteLine("введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n]; 
InputArray(arr);
Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + FindSum(arr));