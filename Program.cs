namespace Numero_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dividable(3));
            Console.WriteLine(Dividable(14));
            Console.WriteLine(Dividable(12));
            Console.WriteLine(Dividable(37));
            Console.WriteLine(Dividable(2137));
        }
        static bool Dividable(int x)

        {
            return x%3 == 0 || x%7 == 0;
        }

    }
}
