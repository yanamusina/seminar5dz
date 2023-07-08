// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size, int leftRange=100, int rightRange=999)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] += rand.Next(leftRange, rightRange + 1);
    }
    return array;
}
int EvenNumbers(int[] evenNumb)
{
    int number = 0;
    for (int i = 0; i < evenNumb.Length; i++)
    {
        if (evenNumb[i] % 2 == 0)
            number+=1;
    }
    return number;
}
void PrintArray(int[] arrayText)
{
    System.Console.WriteLine("["+string.Join(", ", arrayText)+"]");
}
int Readint(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
//~~~~~~~~~~~~~~~~~~~~~~
int  size = Readint("Введите значение массива: ");
int [] array = FillArray(size);
PrintArray(array);
System.Console.WriteLine("Кол-во чет чисел: "+EvenNumbers(array));