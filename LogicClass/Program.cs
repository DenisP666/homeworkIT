namespace ArrayWorker;

internal class Program
{
    static void Main(string[] args)
    {

        int[] Array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        ArrayWorker.ArrayWorkerReverse(Array1);

        for (int i = 0; i < Array1.Length; i++)
        {
            Console.WriteLine(Array1[i]);
        }

        Console.ReadLine();

    }
}
