// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetDataFromUser(string messageForUser) // Запрос диапозона матрицы.
{
    int value = 0;
    bool flag = false;

    while (!flag)

    {
        Console.Write(messageForUser);
        flag = int.TryParse(Console.ReadLine(), out value);
        if (flag == false) 
        {
            Console.WriteLine("Введённое значение не валидно, используйте целые числа.");
        }
    }

    return value;
}

void PrintArray(double[,] matr) // Печать матрицы.
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr) // Заполнение матрицы случайными числами.
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
}

int m = GetDataFromUser("Введите количество строк массива: ");
int n = GetDataFromUser("Введите количество столбцов массива: ");
double[,] matrix = new double[m, n];

FillArray(matrix);
PrintArray(matrix);