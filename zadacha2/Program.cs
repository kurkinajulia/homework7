// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

int GetDataFromUser(string messageForUser) // Запрос диапозона матриц, номера строки, столбца.
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

void FindNumber(int[,] matr, int i, int j) // Нахождение элемента в матрице.
{
    if (i > matr.GetLength(0) | j > matr.GetLength(1))
    {
        Console.WriteLine("Такого элемента в матрице нет.");
        return;
    }
    if ((i < 0) | (j < 0))
    {
        Console.WriteLine("Позиция элемента не может быть отрицательной.");
        return;
    }
    else
    {
        for (int m = 0; m < matr.GetLength(0); m++)
        {
            for (int n = 0; n < matr.GetLength(1); n++)
            {
                matr[m, n] = matr[i, j];
                Console.WriteLine($"Возвращаемый элемент: {matr[i, j]}");
                return;
            }
        }
    }
}

int m = GetDataFromUser("Введите количество строк массива: ");
int n = GetDataFromUser("Введите количество столбцов массива: ");
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);

int i = GetDataFromUser("Введите номер строки с элементом, который необходимо вернуть: ");
int j = GetDataFromUser("Введите номер столбца с элементом, который необходимо вернуть: ");

FindNumber(matrix, i, j);