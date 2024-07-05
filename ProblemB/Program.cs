using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de numeros en las listas: ");
        int cantidad = int.Parse(Console.ReadLine());
        Random rand = new Random();
        LinkedList<int> lista1 = new LinkedList<int>();
        LinkedList<int> lista2 = new LinkedList<int>();
        for (int i = 0; i < cantidad; i++){
            lista1.AddLast(rand.Next(1, 100)); 
            lista2.AddLast(rand.Next(1, 100));
        }
        List<int> primos = new List<int>();
        List<int> perfectos = new List<int>();
        List<int> otros = new List<int>();
        Listita(lista1, primos, perfectos, otros);
        Listita(lista2, primos, perfectos, otros);
        Console.WriteLine("Numeros primos:");
        primos.ForEach(num => Console.Write(num + " "));
        Console.WriteLine();
        Console.WriteLine("Numeros perfectos:");
        perfectos.ForEach(num => Console.Write(num + " "));
        Console.WriteLine();
        Console.WriteLine("Otros números:");
        otros.ForEach(num => Console.Write(num + " "));
        Console.WriteLine();
    }

    static void Listita(LinkedList<int> lista, List<int> primos, List<int> perfectos, List<int> otros){
        foreach (int num in lista){
            if (Primo(num))
                primos.Add(num);
            else if (Perfecto(num))
                perfectos.Add(num);
            else
                otros.Add(num);
        }
    }

    static bool Primo(int num){
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static bool Perfecto(int num)
    {
        if (num < 1) return false;
        int suma = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
                suma += i;
        }
        return suma == num;
    }
}

