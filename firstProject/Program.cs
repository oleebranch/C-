using System;

namespace chsarpclass
{
    class Program
    {
        static void Main(string[] args)
        {
            var Calc = new Calculator();
            double result = Calc.Add(11, 22);
            Console.WriteLine($"the area is {result}");
        }

        class Calculator
        {

            private int result;
            public int Add(int number1, int number2)
            {
                result = number1 + number2;
                return result;
            }

            public int Add(int number1)
            {
                result = result + number1;
                return result;
            }
            public int Subtract(int number1, int number2)
            {
                return number1 + number2;
            }

            public int Division(int number1, int number2)
            {
                result = number1 / number2;
                return result;
            }

            public int PercentageCalculation(int number1, int number2)
            {
                result = (number1 / number2) * 100;
                return result;
            }

            // Area of circle
            public int AreaofCircle(int radius, int Pi = 22 / 7)
            {
                result = radius * radius * Pi;
                return result;
            }
        }
























        //     BasicChair chair = new BasicChair(); 
        //    Console.WriteLine($"{chair.Colour} {chair.NumberofLegs}");

        // }


        //    class BasicChair
        //    {   
        //        public BasicChair(){
        //             Colour = "Red";
        //             CanRoll = true;
        //             NumberofLegs = 6;

        //        }


        //        public string Colour { get; set;}
        //        public int NumberofLegs { get; set;}
        //        public bool CanRoll {get; set;}


        //    }

        //    class Patient
        //    {
        //        public string Name{get; set;}
        //        public int Age{get; set;}
        //    }











        // Console.WriteLine("Olee");
        // string number = Console.ReadLine();
        // int input = int.Parse(number);
        // // if (input == 1)
        // {
        //     System.Console.WriteLine("User selected 1");
        // }
        // else if (input == 2)
        // {
        //     System.Console.WriteLine("user selected 2");
        // }
        // else
        // {
        //     System.Console.WriteLine("Out of options");
        // }
        // switch (input)
        // {
        //     case 1:
        //         System.Console.WriteLine("User selected 1");
        //         break;

        //     case 2:
        //         System.Console.WriteLine("User selected 2");
        //         break;

        // }

        // // using if
        //  if ((input % 3)== 0){
        //      Console.WriteLine("Fizz");
        //  }
        //  else if ((input % 5) == 0){
        //      Console.WriteLine("Fizz Buzz");
        //  }
        //  else if ((input % 7) == 0){
        //      Console.WriteLine("Buzz");
        //  }



        // multiplication table
        // Console.WriteLine("Enter the number:");
        // string number = Console.ReadLine();
        // int input = int.Parse(number);
        // for (int i = 1; i <= 10; i++)
        // {
        //     // Console.WriteLine(i "*" + input + "=" + 1 * input);
        //     // Console.WriteLine("{10} * {1} = {2}", i, input, i * input);
        //     Console.WriteLine($"{i} * {number} = {i*input}");
        // }







        // int number_interger = 10;
        // float n_float = 9.2f;
        // decimal d_number = 12.5m;
        // // number_interger = (int)n_float;

        // char ch = 'a';
        // // // string str = "Clarke Uni";
        // Console.WriteLine(d_number);
        // // Console.WriteLine($"Hello{args[0]}");
        // Console.ReadLine();


    }
}
