// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

Console.Clear();
void FillArray(int[] numbers)
    {
    double length = numbers.Length;
    int index = 0;
        while(index < length)
        {
        numbers[index] = new Random().Next(1,10);
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
int[] numbers = new int[10]; 

   


FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
int min = numbers[0];
int max = numbers[0];

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min) {min = numbers[i] ;}
        if (numbers[i] > max) {max = numbers[i] ;}
    }
Console.WriteLine(max - min);