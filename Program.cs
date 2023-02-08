


namespace Lesson
{
    class program
    {
        public static void Main(string[] args)
        {
            int a = 1, b = 5;

            Console.WriteLine($"a = {a}\t b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a}\t b = {b}");
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;  
            b = temp;
        }

       /* static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
       */
    }
}