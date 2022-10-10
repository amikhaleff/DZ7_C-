Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Введите номер порядковый номер задачи ");
Console.ForegroundColor = ConsoleColor.White;
int Task = int.Parse(Console.ReadLine() ?? "0");

if (Task == 1) ZADACHA_47();
else if (Task == 2) ZADACHA_50();
else if (Task == 3) ZADACHA_52();
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Такой задачи нет в списке!!!");
    Console.ResetColor();
}
void ZADACHA_47()
{
    Console.Clear();

    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void GetArray(double[,] matrix, double min, double max)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min, 1);
            }
        }
    }


    void PrintArray(double[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write("{0,7}", matr[i, j]);
            }
            Console.WriteLine();
        }
    }


    int m = ReadData("Введите количество строк m: ");
    int n = ReadData("Введите количество столбцов n: ");
    double min = ReadData("Введите min: ");
    double max = ReadData("Введите max: ");
    double[,] matrix = new double[m, n];
    Console.WriteLine();
    GetArray(matrix, min, max);
    PrintArray(matrix);
    System.Console.WriteLine();
}

void ZADACHA_50()
{
    Console.Clear();

    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void GetArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(-10, 10);
            }
        }
    }



    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write("{0,5}", matr[i, j]);
            }
            Console.WriteLine();
        }
    }


    int m = ReadData("Введите количество строк m: ");
    int n = ReadData("Введите количество столбцов n: ");
    int row = ReadData("Введите номер строки искомого элемента: ");
    int col = ReadData("Введите номер столбца искомого элемента: ");
    int[,] matrix = new int[m, n];
    GetArray(matrix);
    PrintArray(matrix);
    if (row >= m || col >= n) Console.WriteLine($"Искомого элемента позиции [{row},{col}] в массиве нет");
    else System.Console.WriteLine($"Значение элемента [{row},{col}] равно {matrix[row, col]}");

}

void ZADACHA_52()
{
    Console.Clear();

    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void GetArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(-10, 10);
            }
        }
    }

    void AvgColumsArray(int[,] arr)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, j];

            }

            Console.Write("\nСреднее арифметическое {0}-го столбца = {1,5}", j + 1, Math.Round((sum / arr.GetLength(1)), 1) + ";");


        }

    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write("{0,5}", matr[i, j]);
            }
            Console.WriteLine();
        }
    }


    int m = ReadData("Введите количество строк m: ");
    int n = ReadData("Введите количество столбцов n: ");
    int[,] matrix = new int[m, n];
    Console.WriteLine();
    GetArray(matrix);
    PrintArray(matrix);
    AvgColumsArray(matrix);
    System.Console.WriteLine();
}

