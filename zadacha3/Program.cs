//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = GetDataFromUser("Введите количество строк массива: ");
int n = GetDataFromUser("Введите количество столбцов массива: ");
int[,] matrix = new int[m, n];

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
            Console.WriteLine("Введённое значение не валидно, используйте целые положительные числа.");
        }
    }

    return value;
}

void PrintArray(int[,] matr) // Печать матрицы.
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

void FillArray(int[,] matr) // Заполнение матрицы числами.
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(1, 10);
        }
    }
}

void GetAverage(int[,] matr) // Нахождение среднего арифметического в каждом столбце.
{
    for (int n = 0; n < matr.GetLength(1); n++)
    {
        double average = 0;
        for (int m = 0; m < matr.GetLength(0); m++)
        {
            average = (average + matrix[m, n]);
        }
        average = average / m;
        Console.Write($"{average}; ");
    }
    Console.WriteLine();
}

FillArray(matrix);
PrintArray(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
GetAverage(matrix);