// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int Readint(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i= 0; i<array.Length; i++)
    {
        array[i] += rand.Next(leftRange, rightRange + 1);
    }
    return array;
}
void PrintArray(int[] arrayText)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayText) + "]");
}
int Sum(int[] sumNumber)
{
    int sum = 0;
    for (int i = 0; i < sumNumber.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + sumNumber[i];
        }
    }
    return sum;
}

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
int size = Readint("Введите размер массива: ");
int leftRange = Readint("введите левый предел элементов");
int rightRange = Readint("введите правый предел элементов");
int[] array = FillArray(size, leftRange, rightRange);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine("cумма "+ Sum(array));


