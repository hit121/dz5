// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

Console.Clear();
void FillArray(int[] numbers)
    {
    int length = numbers.Length;
    int index = 0;
        while(index < length)
        {
        numbers[index] = new Random().Next(100,1000);
        index++;
        }


    }
void PrintArray(int[] col)
    {
        int count = col.Length;
        int pos = 0; 
        while(pos < count)
        {
            Console.Write($"{col[pos]} ");
            pos++;
        }
    }
void PrintSumPlus(int[] numbers)
{
    int length = numbers.Length;
    int sumplus = 0;
        for (int i = 0; i < length; i++)
        {
            if (numbers[i] % 2 == 0) 
            {
                sumplus += 1;
            }

        }
       
    Console.WriteLine(sumplus);
}


int[] array = new int[8]; 
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintSumPlus(array);