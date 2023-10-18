using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const int N = 4;
        const int M = 4;

        static void Main(string[] args)
        {
            int[,] matrix = new int[N, M];
            //feltöltés
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = (i + 1) * 10 + (j + 1);
                }
            }

            //kiíratás
            for (int i = 0;i < N; i++)
            {
                for(int j = 0;j < M; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            //sorösszeg
            for (int i = 0; i < N; i++)
            {
                int sorOsszeg = 0;
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j] + "\t|\t");
                    sorOsszeg += matrix[i, j];
                }
                Console.WriteLine(sorOsszeg);
            }

            for (int i = 0; i < M; i++)
            {
                int oszlopOsszeg = 0;
                for(int j = 0; j < N; j++)
                {
                    oszlopOsszeg += matrix[j, i];
                }
                Console.Write(oszlopOsszeg + "\t|\t");
            }
            Console.WriteLine();

            //főátló
            int foatloOsszege = 0;
            for (int i = 0; i < N; i++)
            {
                foatloOsszege += matrix[i, i];
            }
            Console.WriteLine("Főátló összege: " + foatloOsszege);

            //mellékátló
            int mellekatloOsszege = 0;
            for (int i = 0; i < N; i++)
            {
                mellekatloOsszege += matrix[i, 3 - 1];
            }
            Console.WriteLine("Mellékátló összege: " + mellekatloOsszege);

            //főátló feletti elemek összege
            int foatloFelettiElemekOsszege = 0;
            for (int i = 0; i < M-1; i++)
            {
                for (int j = i+1; j < M; j++)
                {
                    foatloFelettiElemekOsszege += matrix[i, j];
                }
            }
            Console.WriteLine("Fő felett:" + foatloFelettiElemekOsszege);

            //mellékátló feletti elemek összege
            int foatloAlattiElemekOsszege = 0;
            for(int i = 0;i < M; i++)
            {
                for(int j = 0;j < i; j++)
                {
                    foatloAlattiElemekOsszege+= matrix[i, j];
                }
            }
            Console.WriteLine("Fő alatti:" + foatloAlattiElemekOsszege);

            //főátló alatti elemek összege
            int mellekatloFelettiElemekOsszege = 0;
            for (int i = 0; i < N-2; i++)
            {
                for (int j = 0; j < M-2-i; j++)
                {
                    mellekatloFelettiElemekOsszege = matrix[i, j];
                }
            }
            Console.WriteLine("Mellék feletti:" + mellekatloFelettiElemekOsszege);

            //mellékátló alatti elemek összege
            int mellekatloAlattiElemekOsszege = 0;
            for (int i = 1; i < N-1; i++)
            {
                for (int j = M-i; j < M-1; j++)
                {
                    mellekatloAlattiElemekOsszege += matrix[i, j];
                }
            }
            Console.WriteLine("Mellék feletti:" + mellekatloAlattiElemekOsszege);

            Console.ReadKey();
        }
    }
}
