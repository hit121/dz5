// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
void FillArray(double[] numbers)
    {
    double length = numbers.Length;
    int index = 0;
        while(index < length)
        {
        numbers[index] = new Random().Next(1,5);
        index++;
        }


    }
void PrintArray(double[] col)
    {
        int count = col.Length;
        int pos = 0; 
        while(pos < count)
        {
            Console.Write($"{col[pos]} ");
            pos++;
        }
    }
void SumUnPlus(double[] numbers)
{
    int length = numbers.Length;
    double sum = 0; 
        for (int i = 0; i < length; i++)
        {
            if (i %2 == 0) 
            {
                sum = sum + numbers[i];
            }

        }
    Console.WriteLine(sum);
        
}


double[] array = new double[6]; 
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumUnPlus(array);