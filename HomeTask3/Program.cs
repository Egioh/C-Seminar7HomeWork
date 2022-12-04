// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] array = new int [,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};
void ColumnAverege (int [,] arr)
{
    double average =0;
for (int i =0; i<arr.GetLength(1); i++)
    {
        for (int j=0; j<arr.GetLength(0);j++)
        {
            average = average+ arr[j,i];

        }
        average = average/(arr.GetLength(0));
        Console.WriteLine($"среднее африфметическое значение столбца {i+1} = {average}");
        average =0;
    }
}
ColumnAverege(array);