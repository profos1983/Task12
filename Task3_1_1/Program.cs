int[,] myArray =
{
   { 5, 8, 3, 10 },
   { 13, 2, 1, 7 },
   { 0, 2, 5, 2 },
   { 3, 8, 3, 45 },
   { 2, 4, 31, 4 }
};

int lenght1 = myArray.GetLength(0);
int lenght2 = myArray.GetLength(1);

Console.WriteLine($"Выводимый массив имеет размерность {lenght1} на {lenght2}");

for (int i = 0; i < lenght1; i++)
{
    for (int j = 0; j < lenght2; j++)
    {
        Console.Write($"{myArray[i, j]} ");
    }
    Console.WriteLine();
}
