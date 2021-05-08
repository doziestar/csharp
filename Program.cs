// using System;

// namespace csharp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             byte number;
//             number = 0;
//             // we can declare and initialize the variable immediately on the same line
//             byte numberMy = 67;
//             int count = 34;
//             // here i added an F in float because the program does not convert datatype float explicitly
//             float myCount = 34.78F;
//             char character = 'B';
//             string name = "dozie";
//             bool isWorking = true;

//             // using var to declare variables

//             var mySecondCount = 34.78F;
//             var myCharacter = 'B';
//             var areWorking = true;
//             Console.WriteLine(name.Length);
//             Console.WriteLine(number);
//             Console.WriteLine(numberMy);
//             Console.WriteLine(count);
//             Console.WriteLine(myCount);
//             Console.WriteLine(character);
//             Console.WriteLine(isWorking);
//             System.Console.WriteLine("using var and system.console.writeline");
//             System.Console.WriteLine(mySecondCount);
//             System.Console.WriteLine(myCharacter);
//             System.Console.WriteLine(areWorking);

//             // checking min and max values
//             System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
//             System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
//             System.Console.WriteLine("using const to declare variables");

//             // const are use to declare local constants. i.e things that cannot change throughout a program
//             const int myConstInt = 45;
//             const float myConstFloat = 56f;
//             System.Console.WriteLine(myConstFloat);
//             System.Console.WriteLine(myConstInt);

//             // type conversion
//             System.Console.WriteLine("type conversion");
//             string nameMy = "true";
//             string nameMy2 = "120";
//             int e = Convert.ToInt32(nameMy2);
//             byte myByte = 5;
//             int d = Convert.ToInt32(myByte);
//             bool c = Convert.ToBoolean(nameMy);
//             System.Console.WriteLine(c);
//             System.Console.WriteLine(d);
//             System.Console.WriteLine(e + 400);

//             System.Console.WriteLine(Dozie(5));


//         }
//             static int Dozie(int num)
//             {
//                 var total = num * num * num;
//                 return total;
//             }
//     }
// }
