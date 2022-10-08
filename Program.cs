Console.Clear();
Console.Write("Введите номер порядковый номер задачи ");
int Task = int.Parse(Console.ReadLine() ?? "0");

if (Task == 1) ZADACHA_47();
else if (Task == 2) ZADACHA_50();
else if (Task == 3) ZADACHA_52();
else Console.WriteLine("Такой задачи нет в списке");

void ZADACHA_47()
{
    Console.Clear();

    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void GetArray(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000)) / 10;
            }
        }
    }


    void PrintArray(double[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]}\t");
            }
            Console.WriteLine();
        }
    }


    int m = ReadData("Введите количество строк m: ");
    int n = ReadData("Введите количество столбцов n: ");
    double[,] matrix = new double[m, n];
    Console.WriteLine();
    GetArray(matrix);
    PrintArray(matrix);
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
                Console.Write($"{matr[i, j]}\t");
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
            
            Console.Write(Math.Round((sum/arr.GetLength(1)),1) + "; ");


        }
        
    }

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
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
System.Console.Write("Среднее арифметическое каждого столбца: ");
AvgColumsArray(matrix);
System.Console.WriteLine();
}

