//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] array = new double[4,4];

void fillArrayRandomNumbers (double [,] arr)
{

    for (int i =0; i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
            {
                arr[i,j] = new Random().NextDouble() *10;
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
    }
}

fillArrayRandomNumbers(array);