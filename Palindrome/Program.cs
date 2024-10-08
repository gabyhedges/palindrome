namespace Palindrome//names the program
{
    internal class Program//allows for classes
    {
        static void Main(string[] args)//main program. entrypoint of program
        {
            string inputStr;//initialises variable
            string reverseStr = string.Empty;//initialises variable as empty
            Console.WriteLine("Enter a string to check if it is a palindrome");//prompt to user
            inputStr = Console.ReadLine();//accepts input and stores in variable
            if (inputStr != null)//if statement. if input is not nothing
            {
                for (int i = inputStr.Length -1; i >= 0; i--)//for statement initialises integer length, condition and decrement
                {
                    reverseStr += inputStr[i].ToString();//reverses the string
                }
                if (reverseStr == inputStr)//if statement if reversed input and input match
                {
                    Console.WriteLine("The string is a palindrome");//if true this statement is printed
                }
                else
                {
                    Console.WriteLine("String is NOT a palindrome");//if false this statement is printed
                }
                    Console.ReadKey();//prevents console from closing until a key is hit
            }
            
        }
    }
}