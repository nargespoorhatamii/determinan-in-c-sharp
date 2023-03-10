using System;
namespace Project
{
    class test_1 
    {
        public static void main(double[,] matrix)
        {
            
            double[3, 3] det = new double[3, 3];

            for (int i = 0; i < 3; i++)
            { for (int j = 0; j < 3; j++)
                { [i, j]det; }
            }
            determinan = Console.WriteLine([0, 0]det * ([1, 1]det *[2, 2]det -[1, 2]det *[2, 1]det)-[0,1]det * ([1, 2]det *[0, 2]det -[1, 0]det*[2,2])+[0,2]det*([1,1]det*[0,2]det-[1,0]det*[2,2]det));
            Console.WriteLine(determinan);
        }
    }
}
