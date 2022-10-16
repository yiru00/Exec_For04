internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 20; i++)
        {
            int foo = 3;
            int bar = 5;
            int foobar = 15;

            if (i % foo == 0)
            {
                Console.WriteLine("foo");
            }
            else if (i % bar == 0)
            {
                Console.WriteLine("bar");
            }
            else if (i % foobar == 0)
            {
                Console.WriteLine("foobar");
            }
            else
            {
                Console.WriteLine(i);
            }

        }
    }
}