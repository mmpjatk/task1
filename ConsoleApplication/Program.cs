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
        long sum1 = 0;
        foreach (int number in numbers)
            sum1 += number;
        return (double) sum1 / numbers.Length;
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

