// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int Readint(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
float[] FillArray(int size, int leftRange, int rightRange)
{
    float[] array = new float[size];
    Random rand = new Random();
    for (int i= 0; i<array.Length; i++)
    {
        array[i] += (float)Math.Round(rand.Next(leftRange, rightRange +1)+rand.NextDouble(),2);
    }
    return array;
}
void PrintArray(float[]arrayText)
{
    System.Console.WriteLine("["+string.Join(", ", arrayText)+"]");
}
float Max(float[]numberMax)
{
    float max=numberMax[0];
    for(int i=0; i<numberMax.Length; i++)
    {
        if (numberMax[i]> max){
            max=numberMax[i];
        }
    }
    return max;
}
float Min(float[] numberMin)
{
    float min=  numberMin[0];
    for(int i=0; i<numberMin.Length; i++)
    {
        if (numberMin[i]<min){
            min=numberMin[i];
        }
    }
    return min;
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
int size= Readint("введите размер массива: ");
int leftRange = Readint("введите левый предел элементов");
int rightRange = Readint("введите правый предел элементов");
float[] array = FillArray(size,leftRange,rightRange);
PrintArray(array);
System.Console.WriteLine("max: "+Max(array));
System.Console.WriteLine("min: "+ Min(array));
float diff=Max(array)-Min(array);
System.Console.WriteLine("different: "+ diff);


