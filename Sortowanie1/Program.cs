using System;

class Program
{
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            // Przesuwanie elementów większych niż klucz w prawo
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    static void Main()
    {
        // Generowanie tablicy stu losowych liczb całkowitych
        Random rand = new Random();
        int[] numbers = new int[100];
        for (int i = 0; i < 100; i++)
        {
            numbers[i] = rand.Next(1, 1000);
        }

        // Wyświetlanie tablicy przed sortowaniem
        Console.WriteLine("Tablica przed sortowaniem:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Sortowanie tablicy za pomocą InsertionSort
        InsertionSort(numbers);

        // Wyświetlanie tablicy po sortowaniu
        Console.WriteLine("Tablica po sortowaniu:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Sortowanie tablicy za pomocą wbudowanego sortowania
        int[] sortedNumbersBuiltIn = (int[])numbers.Clone();
        Array.Sort(sortedNumbersBuiltIn);

    }
}
