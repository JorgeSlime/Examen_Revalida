using System;

class Program
{
    static void Main(){
        int N;

        Console.Write("Ingrese el tamaño de la matriz (N x N): ");
        N = int.Parse(Console.ReadLine());
        int[,] matriz1 = new int[N, N];
        int[,] matriz2 = new int[N, N];
        int[,] resultado = new int[N, N];
        Console.WriteLine("Primera matriz:");
        for (int i = 0; i < N; i++){
            for (int j = 0; j < N; j++){
                matriz1[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Segunda matriz:");
        for (int i = 0; i < N; i++){
            for (int j = 0; j < N; j++){
                matriz2[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < N; i++){
            for (int j = 0; j < N; j++){
                resultado[i, j] = 0;
            }
        }
        for (int i = 0; i < N; i++){
            for (int j = 0; j < N; j++){
                for (int k = 0; k < N; k++){
                    resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                }
            }
        }
        Console.WriteLine("El resulta es: ");
        for (int i = 0; i < N; i++){
            for (int j = 0; j < N; j++){
                Console.Write(resultado[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

