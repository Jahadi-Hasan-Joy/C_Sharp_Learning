internal class Program
{
    private static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());

        // if-else
        if (a == 1 || a == 2)
        {
            Console.WriteLine("a is 1 or 2");
        }
        else if (a >= 3 && a <= 8)
        {
            Console.WriteLine("a is between 3 and 8");
        }
        else
        {
            Console.WriteLine("a is not 1, 2, 3, or 4");
        }

        // switch
        switch (a)
        {
            case 1:
            case 2:
                Console.WriteLine("a is 1 or 2");
                break;

            case >= 3 and <= 8:
                Console.WriteLine("a is between 3 and 8");
                break;

            default:
                Console.WriteLine("a is not 1, 2, 3, or 4");
                break;
        }
    }
}
