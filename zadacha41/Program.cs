// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
}

int Positive(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
    
        {
            if (a[i] > 0) count++;
        }
    }
    return count;
}

Console.Write("Введите количество чисел в массиве М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Заполните массив числами: ");
int[] array = new int[m];
FillArray(array);
int result = Positive(array);
Console.WriteLine($"Количество положительных чисел в массиве равно {result}");

