using System;
using System.Collections.Generic;
namespace PalindromeCheck
{
    class Program
    {
        static public int numb = 999999;
        static public int count = 999;
        static public int count2 = 999;
        static public bool check = true;
        static List<int> Palinlist = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Verification!");
            while(check)
            {
                numb = count2 * count;
                if (numb.ToString().Length == 6 && count > 0)
                {
                    if (numb.ToString()[0] == numb.ToString()[5] && numb.ToString()[1] == numb.ToString()[4] && numb.ToString()[2] == numb.ToString()[3])
                    {
                        Palinlist.Add(numb);
                    }
                    count = count - 1;
                }
                if(count <= 0 || numb.ToString().Length < 6)
                {
                    count = 999;
                    if(count2 > 0)
                    {
                        count2 = count2 - 1;
                    }
                    if(count2 == 0)
                    {
                        Palinlist.Sort();
                        foreach(int i in Palinlist)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("Done!");
                        check = false;
                    }
                    
                }


            }
        }
    }
}
