namespace Route.OOP03.Overloading
{
    internal static class Calculator
    {
        public static int SumNumbers(int a, int b)
        {
            return a + b;
        }

        public static long SumNumbers(long a, long b)
        {
            // long + int => long
            // long + long => long
            return  a + b;
        }
        public static double SumNumbers(double a, double b)
        {
            // long + int => long
            // long + long => long
            return  a + b;
        }

        public static int SumNumbers(int a, int b, int c)
        {
            return a + b + c;
        }

        //public static double SumNumbers(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

    }
}
