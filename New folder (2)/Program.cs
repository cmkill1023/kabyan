using System;

namespace Maindet
{
    class Program
    {
        
        private static int Det2x2(int[][] m)
        {
            return (m[0][0] * m[1][1] - m[0][1] * m[1][0]);
        }

        
        private static int Det3x3(int[][] mat)
        {
            int a = mat[0][0];
            int b = mat[0][1];
            int c = mat[0][2];

            int[][] efhi = {
                new int[] { mat[1][1], mat[1][2] },
                new int[] { mat[2][1], mat[2][2] }
            };

            int[][] dfgi = {
                new int[] { mat[1][0], mat[1][2] },
                new int[] { mat[2][0], mat[2][2] }
            };

            int[][] degh = {
                new int[] { mat[1][0], mat[1][1] },
                new int[] { mat[2][0], mat[2][1] }
            };

            return a * Det2x2(efhi) - b * Det2x2(dfgi) + c * Det2x2(degh);
        }

        internal static void Run()
        {
            int[][] mat = new int[3][];

            Console.WriteLine("กรุณากรอกค่าเมทริกซ์ 3x3:");
            for (int i = 0; i < 3; i++)
            {
                mat[i] = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"ค่าเมทริกซ์[{i}][{j}]: ");
                    mat[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("เมทริกซ์:");
            foreach (var row in mat)
            {
                foreach (var item in row)
                    Console.Write(item + " ");
                Console.WriteLine();
            }

            Console.WriteLine();

            int det = Det3x3(mat);

            Console.WriteLine($"ดีเทอร์มิแนนต์ ของ เมทริกซ์ 3x3 คือ: {det}");
        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}
