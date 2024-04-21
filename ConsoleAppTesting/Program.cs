using System.Runtime.CompilerServices;
using System;
using System.Text;
///Задание:
///Консольное приложение.
///Программа запрашивает у пользователя ввод двух чисел
///Отслеживание некорректного ввода
///По двум числам нужно составить матрицу умножения
///x = 3, y = 4
///[1, 2, 3, 1x1 1x2 1x3
/// 2, 4, 6, 2x1 2x2 2x3
/// 3, 6, 9, ...
/// 4, 8, 12]
[assembly:InternalsVisibleTo("ConsoleInputOutputHandler")]
namespace ConsoleAppTesting
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int x = GetUserInput("x");
            int y = GetUserInput("y");

            Console.WriteLine("Матрица умножения:");
            Console.WriteLine(CreateMatrix(x, y));
        }
        internal static int GetUserInput(string variableName)
        {
            int input;
            Console.WriteLine($"Введите {variableName}:");
            if (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
                Console.WriteLine($"Ошибка: Введите целое положительное число для: {variableName}!");

            return input;
        }
        internal static string CreateMatrix(int x, int y)
        {
            int[,] matrix = new int[y,x];
            StringBuilder stringMatrix = new StringBuilder();
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matrix[i, j] = (i+1) * (j+1);
                    stringMatrix.Append($"{matrix[i, j]} ");
                    //Console.Write($"{matrix[i, j]} ");
                }
                //Console.WriteLine();
                stringMatrix.AppendLine();
            }
            return stringMatrix.ToString();
        }
    }
}