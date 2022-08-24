using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Please send feedback on discord 


            Console.WriteLine("What is your name");
            string Name = Console.ReadLine();


            Console.WriteLine("what is your favorite color");
            string color = Console.ReadLine();

            Console.WriteLine("what is your favorite animal");
            string animal = Console.ReadLine();

            Console.WriteLine("what is your favorite band");
            string band = Console.ReadLine();


            Console.WriteLine($"There was a person named {Name} used to be an adventurer like you, then they took an arrow in the knee.");
            Console.WriteLine($"They use too slay dragons back in the day, there armor was {color}");
            Console.WriteLine($"But let me not go over the past of my skyrim days. You said you like {animal}'s nice I love them, they can be kinda smelly though.");
            Console.WriteLine($"And you also said that your favorite band was {band} thats awesome,I dont really listen to music or like music sense I am a computer. Maybe if I had AI installed i would like music more.");



            Console.WriteLine("Give me a number to + or -");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to + or - to the first number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"the sum is {sum}");
            //add and subtract




            Console.WriteLine("Give me a number to multiply");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first number");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"the product is {product}");
            //multiply



            Console.WriteLine("give me a number to divide");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me another number");
            num2 = int.Parse(Console.ReadLine());

            int div = Divide(num1, num2);
            Console.WriteLine($"the answer is {div}");
            //divide



            Console.WriteLine("now lets find absolute value give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me another number");
            num2 = int.Parse(Console.ReadLine());

            int mod = modulus(num1, num2);
            Console.WriteLine($"the answer is {mod}");
            //modulus




        }
        public static int modulus(int x, int y) 
        { 
        
            return x % y;
        
        }
        public static int Divide(int x, int y) 
        {

            return (x / y);

        }
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
       
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

            
         
    }
    

}
