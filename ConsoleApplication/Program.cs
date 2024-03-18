class Program {
    public static void Main(string[] args)
    {
        for (int i = 0; i < 10; ++i)
        {
            HelloWorld();
        }
    }

    public static void HelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }

    public static double CalculateAverage(int[] numbers)
    {
        long sum5 = 0;
        foreach (int number in numbers)
            sum5 += number;
        return (double) sum5 / numbers.Length;
    }
    
    public static int FindMaximum(int[] numbers)
    {
        int max = numbers[0]; 
        foreach (int number in numbers)
            if (number > max)
                max = number;
        return max;
    }
}

