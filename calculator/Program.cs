using System;

namespace calculator
{
    class Program
    {
       


      
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the below key to perform corresponding operation");
            Console.WriteLine("Please enter + or - or * or /");
            string symbol = Console.ReadLine();
            double Result = 0;
            if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/")
            {
                Console.Write("Enter first number:-");
                double firstNum = double.Parse(Console.ReadLine());
                Console.Write("Enter second number:-");
                double secondNum = double.Parse(Console.ReadLine());
            
                switch (symbol)
                {
                    case "+":
                        Result = firstNum + secondNum;
                       
                          break;
                    case "-":
                        Result = firstNum - secondNum;
                       
                          break;
                    case "*":
                        Result = firstNum * secondNum;
                       
                          break;
                    case "/":
                        
                        Result =   firstNum / secondNum;
                        break;
                    
                }
                 
                Console.WriteLine("Result is :" + Result);
               
            }
            else
            {
                Console.WriteLine("plz select a valid option");
            }
            Console.ReadLine();
        }
       
       
    }
}
