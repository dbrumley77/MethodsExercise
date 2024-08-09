namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MadLib();
            Console.WriteLine();

            Console.WriteLine(Add(10,10));
            Console.WriteLine(Subtract(10, 5));
            Multiply(10, 5);
            Divide(10, 5);



        }
        public static int Add(int num1, int num2)
        {
            int answer = num1 + num2;
            return answer;
        }

        public static int Subtract(int num1, int num2)
        {
            int answer = num2 - num1;
            return answer;
        }

        public static void Multiply(int num1, int num2)
        {
            int answer = num1 * num2;
            Console.WriteLine(answer);
        }

        public static void Divide(int num1, int num2)
        {
            int answer = num1 / num2;
            Console.WriteLine(answer);
        }

        public static void MadLib()
        {

            Console.WriteLine("Enter a kind of animal");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter a color");
            string color = Console.ReadLine();

            Console.WriteLine("Enter a type of fruit");
            string fruit = Console.ReadLine();

            Console.WriteLine("Enter a type of shape: ");
            string shape = Console.ReadLine();

            Console.WriteLine($"Who lives in a {fruit} under the sea? \n" +
                              $"Absorbent and {color} is he. If nautical \n" +
                              $"Nonsense be something you wish. Then drop on the deck \n" +
                              $"and flop like an {animal}. Ready? Spongebob {shape} pants!");
            Console.WriteLine();
        }



        
    }
}
