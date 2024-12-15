namespace C3_3_Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
             #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

 //int.TryParse(Console.ReadLine(), out int num);
 //Console.WriteLine($"Input: {num}");
 //if (num % 3 == 0 || num % 4 == 0)
 //    Console.WriteLine($"Output: Yes");
 //else
 //    Console.WriteLine($"Output: No");

 #endregion

 #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
 //int.TryParse(Console.ReadLine(), out int num);
 //Console.WriteLine($"Input: {num}");
 //if (num >= 0)
 //    Console.WriteLine("Output: positive");
 //else
 //    Console.WriteLine("Output: negative");
 #endregion

 #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
 //int.TryParse(Console.ReadLine(), out int X);
 //int.TryParse(Console.ReadLine(), out int Y);
 //int.TryParse(Console.ReadLine(), out int Z);

 //if (X > Y && X > Z)
 //{
 //    if (Y > Z)
 //    {
 //        Console.WriteLine($"Max Number is : {X}");
 //        Console.WriteLine($"Min Number is : {Z}");
 //    }
 //    else
 //    {
 //        Console.WriteLine($"Max Number is : {X}");
 //        Console.WriteLine($"Min Number is : {Y}");

 //    }
 //}

 //else if (Y > X && Y > Z)
 //{
 //    if (X > Z)
 //    {
 //        Console.WriteLine($"Max Number is : {Y}");
 //        Console.WriteLine($"Min Number is : {Z}");
 //    }
 //    else
 //    {
 //        Console.WriteLine($"Max Number is : {Y}");
 //        Console.WriteLine($"Min Number is : {Z}");

 //    }


 //}

 //else if (Z > Y && Z > X)
 //{
 //    {
 //        if (X > Y)
 //        {
 //            Console.WriteLine($"Max Number is : {Z}");
 //            Console.WriteLine($"Min Number is : {Y}");
 //        }
 //        else
 //        {
 //            Console.WriteLine($"Max Number is : {Z}");
 //            Console.WriteLine($"Min Number is : {X}");

 //        }
 //    }

 //}

 //////another solution

 ////int Max = Math.Max(X, Math.Max(Y, Z));
 ////int Min = Math.Min(X, Math.Min(Y, Z));

 ////Console.WriteLine($"Max Number is : {Max}");
 ////Console.WriteLine($"Min Number is : {Min}");
 #endregion

 #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
 //int.TryParse(Console.ReadLine(), out int num);
 //Console.WriteLine($"Input: {num}");
 //string message = num % 2 == 0 ? "Output: Even" : "Output: Odd";
 //Console.WriteLine(message); 
 #endregion

 #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
 //Char Ch = Convert.ToChar(Console.ReadLine());

 //switch (Ch)
 //{
 //    case 'a':
 //    case 'A':
 //    case 'e':
 //    case 'E':
 //    case 'i':
 //    case 'I':
 //    case 'o':
 //    case 'O':
 //    case 'u':
 //    case 'U':
 //        Console.WriteLine("Vowel");
 //        break;
 //    default:
 //        Console.WriteLine("consonant");
 //        break;
 //}
 #endregion

 #region 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
 //    int.TryParse(Console.ReadLine(), out int num);
 //    int X = 1;
 //    Console.WriteLine($"Input: {num}");
 //    Console.Write($"Output: ");
 //to: if (num >= X)
 //    {
 //        Console.Write($"{X} ");
 //        X++;
 //        goto to;
 //    }

 #endregion

 #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

 //    int.TryParse(Console.ReadLine(), out int num);
 //    Console.WriteLine($"Input: {num}");
 //    int x = 1 , result ;
 //    Console.Write($"Output: ");
 //to: if (x <= 12) 
 //    {
 //        result = num * x;
 //        Console.Write($"{result} ");
 //        x++;
 //        goto to;
 //    }
 #endregion

 #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
 // int.TryParse(Console.ReadLine(), out int num);
 // int x = 1;
 // Console.WriteLine($"Input: {num}");
 // Console.WriteLine("OutPut: ");
 //to: if (num > x )
 // {
 //     ++x;
 //     if(x % 2 == 0)
 //     Console.Write($"{x} ");
 //     goto to;
 // }

 #endregion

 #region 9- Write a program that takes two integers then prints the power.
 int.TryParse(Console.ReadLine(), out int num1);
 int.TryParse(Console.ReadLine(), out int pow);
 double res = 1;
 int x = 1;
 Console.WriteLine($"Input: {num1} {pow}");
 Console.Write("Output: ");
to: if (pow >= x)
 {
     res *= num1;
     x++;
     goto to;
 }
 Console.WriteLine(res);

 //////Anouther solution 
 ////res += Math.Pow(num1, pow);
 ////Console.WriteLine(res);


 #endregion

             #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int.TryParse(Console.ReadLine(), out int n1);
            //int.TryParse(Console.ReadLine(), out int n2);
            //int.TryParse(Console.ReadLine(), out int n3);
            //int.TryParse(Console.ReadLine(), out int n4);
            //int.TryParse(Console.ReadLine(), out int n5);

            //Console.WriteLine($"enter marks of five subjects: {n1} {n2} {n3} {n4} {n5}");

            //int total = n1 + n2 + n3 + n4 + n5,
            //    average = ((n1 + n2 + n3 + n4 + n5) / 5);
            //float percentage = (total / 500.0f) * 100; 
            //Console.WriteLine($"Average = {average}");
            //Console.WriteLine($"Percentage = {percentage}");

            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.

            #endregion

            #region 12- Write a program to create a Simple Calculator.

            
            //Console.WriteLine("Enter first number:");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.WriteLine("Enter second number:");
            //int.TryParse(Console.ReadLine(), out int num2);

            //Console.WriteLine("Enter an operator (+, -, /, *):");
            //char ch = Convert.ToChar(Console.ReadLine());

            //switch (ch)
            //{
            //    case '+':
            //        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //        break;
            //    case '/':
            //        if (num2 != 0)  
            //            Console.WriteLine($"{num1} / {num2} = {num1 / (float)num2}");
            //        else
            //            Console.WriteLine("Division by zero is not allowed.");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        break;
            //}

            #endregion


        }
    }
}
