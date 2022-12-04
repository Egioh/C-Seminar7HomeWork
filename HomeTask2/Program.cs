// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("введите номер строки");
int row= int.Parse (Console.ReadLine());
Console.WriteLine("введите номер столбца");
int col= int.Parse (Console.ReadLine());

int [,] array = new int[4,4];

void fillArrayRandomNumbers (int [,] arr)
{

    for (int i =0; i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
            {
                arr[i,j] = new Random().Next(1,10);
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
    }
}

fillArrayRandomNumbers(array);
if (row<4 && col<4) Console.Write(array[row,col]);
else Console.Write ("такого элемента нет");