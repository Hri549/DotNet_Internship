using System;
using System.Linq;
using System.Collections.Generic;
 
class LinqTask
{
    static void Main(string[] args)
    {
        string str;
 
        Console.WriteLine("Input string : ");
        str = Console.ReadLine();        
 
        var Frequency = from x in str
                   group x by x into y
                   select y;
        Console.Write("The frequency of the characters in string :\n");
        foreach (var Arr in Frequency)
        {
            Console.WriteLine("Character " + Arr.Key + ": " + Arr.Count() + " times");
        }
        Console.ReadLine();
    }
}