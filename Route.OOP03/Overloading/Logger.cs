namespace Route.OOP03.Overloading
{
    internal class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
        public static void Log(string level, string message)
        {
            // [WARNING]: This user accessed a sold out product
            // [ERROR]: User canot buy this product
            Console.WriteLine($"[{level.ToUpper()}]: {message}");
        }
        public static void Log(string level, string message, DateTime logTime)
        {
            // [WARNING]: This user accessed a sold out product
            // [ERROR]: User canot buy this product
            Console.WriteLine($"[{level.ToUpper()}]: {message} at {logTime:HH:mm:ss}");
        }
    }
}
