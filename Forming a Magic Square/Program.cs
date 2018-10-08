using System;

namespace Forming_a_Magic_Square
{
    /// <summary>
    /// Problem: https://www.hackerrank.com/challenges/magic-square-forming/problem
    /// </summary>
    class Program
    {
        static int getCost(int[] s, int[] possible)
        {
            int cost = 0;
            for (int i = 0; i < 9; i++)
            {
                cost += Math.Abs((s[i] - possible[i]));
            }
            return cost;
        }
        // Complete the formingMagicSquare function below.
        static int formingMagicSquare(int[] s)
        {
            //Quadrados perfeitos possiveis baseados nas informações fornecidas pelo problema.
            int[][] possible = new int[8][];
            possible[0] = new int[9] { 8, 1, 6, 3, 5, 7, 4, 9, 2 };
            possible[1] = new int[9] { 4, 3, 8, 9, 5, 1, 2, 7, 6 };
            possible[2] = new int[9] { 2, 9, 4, 7, 5, 3, 6, 1, 8 };
            possible[3] = new int[9] { 6, 7, 2, 1, 5, 9, 8, 3, 4 };
            possible[4] = new int[9] { 6, 1, 8, 7, 5, 3, 2, 9, 4 };
            possible[5] = new int[9] { 8, 3, 4, 1, 5, 9, 6, 7, 2 };
            possible[6] = new int[9] { 4, 9, 2, 3, 5, 7, 8, 1, 6 };
            possible[7] = new int[9] { 2, 7, 6, 9, 5, 1, 4, 3, 8 };
            int cost = 0,
                minCost = 99;
            for (int i = 0; i < 8; i++)
            {
                cost = getCost(s, possible[i]);
                if (minCost > cost)
                    minCost = cost;
            }
            return minCost;
        }

        static void Main(string[] args)
        {
            string wolo = Console.ReadLine() + " " + Console.ReadLine() + " " + Console.ReadLine();
            int[] matrix = new int[9];

            for (int i = 0; i < 9; i++)
            {
                matrix[i] = int.Parse(wolo[i * 2].ToString());

            }

            int result = formingMagicSquare(matrix);

            Console.WriteLine(result);
        }
    }
}
