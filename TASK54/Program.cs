internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"\nВведите размер массива строки x столбцы и диапазон случайных значений:");
        int m = InputNumbers("Введите количество строк:");
        int n = InputNumbers("Введите количество столбцов:");
        int range = InputNumbers("Введите диапазон чисел в массиве: от 1 до");
        Console.ReadLine();
        Console.WriteLine("Неотсортированный массив:");

        int[,] array = new int[m, n];
        CreateArray(array);
        PrintArray(array);

        void OrderArrayLines(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int a = 0; a < array.GetLength(1) - 1; a++)
                    {
                        if (array[i, a] < array[i, a + 1])
                        {
                            int temp = array[i, a + 1];
                            array[i, a + 1] = array[i, a];
                            array[i, a] = temp;
                        }
                    }
                }
            }
        }
        Console.WriteLine($"\nОтсортированный массив:");
        OrderArrayLines(array);
        PrintArray(array);

        void PrintArray(int[,] array)
        {
            throw new NotImplementedException();
        }

        int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        void CreateArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}