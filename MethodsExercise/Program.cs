namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal");
            string animal = Console.ReadLine();

            Console.WriteLine("who is your favorite rapper");
            string rapper = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, his favorite color is {color}.");
            Console.WriteLine($"His favorite animal is a {animal}, and his favorite rapper is {rapper}.");

            Console.WriteLine(Sum(5, 5));
            Console.WriteLine(Multiply(5, 5));
            Console.WriteLine(Subtracting(9,8));
            Console.WriteLine(Divide(14, 7));

        }
        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;


            return num1 + num2;
        }
        public static int Multiply(int x, int y)
        {


            return x * y;

        }
        public static int Subtracting(int x, int y)
        {
            return x - y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
