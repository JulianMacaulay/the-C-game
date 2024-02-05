using System;
using System.Reflection.Metadata;

namespace Helloworld
{
    class Program
    {
        static void Main()
        {
            string ans = "";
            string ans0 = "";
            int count = 0;
            int count1 = 0;

            Console.WriteLine("Welcome to DICE game");

            while (ans != "NO")
            {   
                Console.WriteLine("Are you prepared to throw the dice(YES/NO):");
                ans0 = Console.ReadLine().ToUpper();

                if(ans0 !="NO")
                    {
                    Random rnd = new Random();
                    int user= rnd.Next(1, 7);
                    Console.WriteLine("user:" + user);
                    int n = rnd.Next(1, 7);
                    Console.WriteLine("Computer:" + n);
                
                    
                if (user == n)
                {
                    Console.WriteLine("same results");
                    count += 1;
                }
                else if (user > n)
                {
                    Console.WriteLine("User wins");
                    count1 += 1;
                }
                else if (user < n)
                {
                    Console.WriteLine("Computer wins");
                    count += 1;
                }

                    }
            Console.WriteLine("Do u want to continue(YES/NO):");
            ans = Console.ReadLine().ToUpper();
            Console.WriteLine("---------------------------------------");
                    
            }
        Console.WriteLine("User wins " + count + " times");
        Console.WriteLine("Computer wins " + count1 + " times");
        }
    }
}