public class Quiz{
    public static int [][] sum(int[][] a ){
 

    }










}using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesProject.Exercises
{
    class E0121_Determinant3x3Matrix
    {
        internal static void Run()
        {
            var mat = new int[][] {
                new int[]{ 6, 1, 1 },
                new int[]{ 4, -2, 5 },
                new int[]{ 2, 8, 7 }
            };

            Console.WriteLine("Matrix:");
            foreach (var row in mat)
            {
                foreach (var item in row)
                    Console.Write(item + " ");
                Console.WriteLine();
            }

            Console.WriteLine();

            var a = mat[0][0];
            var b = mat[0][1];
            var c = mat[0][2];

            var efhi = new int[][]
            {
                new int[] { mat[1][1], mat[1][2] },
                new int[] { mat[2][1], mat[2][2] },
            };

            var dfgi = new int[][]
            {
                new int[] { mat[1][0], mat[1][2] },
                new int[] { mat[2][0], mat[2][2] },
            };

            var degh = new int[][]
            {
                new int[] { mat[1][0], mat[1][1] },
                new int[] { mat[2][0], mat[2][1] },
            };

            int det = (
                a * Det2x2(efhi)
                - b * Det2x2(dfgi)
                + c * Det2x2(degh)
                );

            Console.WriteLine(
                $"Determinant of matrix is: {det}");

            Console.ReadKey();
        }

        private static int Det2x2(int[][] m)
        {
            return (
                m[0][0] * m[1][1]
                - m[0][1] * m[1][0]
                );
        }
    }
}
