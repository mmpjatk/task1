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
        long sum = 0;
        foreach (int number in numbers)
            sum += number;
        return (double) sum / numbers.Length;
    }

}

