// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//https://github.com/profimars/Task60
void CreateMatrix(int[,,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    int l = A.GetLength(2);
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                A[i, j, k] = rnd.Next(1, 100);
            }
        }
    }
}

void PrintMatrix(int[,,] A)
{
    Console.WriteLine();
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    int l = A.GetLength(2);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                int element = A[i, j, k];
                Console.Write($"{element,3}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите первое измерение матрицы m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе измерение матрицы n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье измерение матрицы l");
int l = Convert.ToInt32(Console.ReadLine());
int[,,] A = new int[m, n, l];
CreateMatrix(A);
PrintMatrix(A);
