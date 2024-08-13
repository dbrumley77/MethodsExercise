namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MadLib();
            //Console.WriteLine();

            Console.WriteLine(Add(5,6,9,4));
            //Console.WriteLine(Subtract(10, 5));
            //Multiply(10, 5);
            //Divide(10, 5);

            // Console.WriteLine(SendEmail("dougie@truecoders.io"));

            //Console.WriteLine($"The longest length is {LongestLength(10, 5)}");

            //Console.WriteLine(Add(array));


        }

        public  static bool SendEmail(string emailAddress)
        {
            if (emailAddress == "cwinton@truecoders.io")
            {
                // Send the email and return true, for success
                return true;
            }
            else
            {
                // Don't send the email and return false, for failure
                return false;
            }
        }
        //public static int Add(int num1, int num2)
        //{
        //    int answer = num1 + num2;
        //    return answer;
        //}

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


        public static int AreaAquare(int num1, int num2)
        {
            int sgft = num1 * num2;
            return sgft;
        }

        public static int LongestLength(int length1, int length2)
        {
            
            if (length1 > length2)
            {
                return length1;
            }
            else return length2;
        }

        //static int[] array = new int[] { 2, 3, 4, 5 };
        public static int Add(params int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        //public static int Add(int number1, int number2)
        //{
        //    return number1 + number2;
        //}



    }
}
