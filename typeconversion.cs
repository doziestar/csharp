using System;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.Write("enter the temperature");
            int isRaining = 9;
            // int isRaining = Console.ReadLine();
            
            

            if (isRaining < 10)
            {
                System.Console.WriteLine("bring your umbrella");

            }else if (isRaining > 15 && isRaining < 30)
            {
                System.Console.WriteLine("the weather is great");
            }else
            {
                System.Console.WriteLine("The weather is hot");
            }

            // Calc();
            GuessingGame();

        }
        static void Calc()
        {
            System.Console.Write("enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("enter the operator: ");
            string oper = Console.ReadLine();
            
            if (num3 != 0){
                if (oper == "+"){
                    double result = num1 + num2 + num3;
                    System.Console.WriteLine(result);
                }else if (oper == "-"){
                    double result = num1 - num2 - num3;
                    System.Console.WriteLine(result);
                }else{
                    double result = num1 * num2 * num3;
                    System.Console.WriteLine(result);
                }
            }else{
                if (oper == "+"){
                    double result = num1 + num2;
                    System.Console.WriteLine(result);
                }else if (oper == "-"){
                    double result = num1 - num2;
                    System.Console.WriteLine(result);
                }else{
                    double result = num1 * num2;
                    System.Console.WriteLine(result);
                }
            }
        }
        static void GuessingGame(){
            string secretNumber = "dozie";
            int guessCount = 0;
            int guessLimit = 3;
            string guess = "";
            while (guess != secretNumber){
                if (guessCount < guessLimit){
                System.Console.WriteLine("enter a guess, make sure it is a word not a number: ");
                guess = Console.ReadLine();
                guessCount++;

                if (guess == secretNumber){
                    System.Console.WriteLine("You win");
                }
                }else{
                    System.Console.WriteLine("You lose");
                }
            }
        }
    }
}