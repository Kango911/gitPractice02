namespace gitPractice;

public class task2
{
    public static void Task2()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        DoTask2(a, b, c);
    }

    private static void DoTask2(int a, int b, int c)
    {
        for (int i = a; i < b; i++)
        {
            if (i % c == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}