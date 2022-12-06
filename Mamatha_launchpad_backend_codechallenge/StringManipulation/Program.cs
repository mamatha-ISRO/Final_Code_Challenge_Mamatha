// See https://aka.ms/new-console-template for more information
//Code to iterate through 
//list with out for each or for loop

using System;
using System.Collections.Generic;
using System.Linq;

public static class QuestionClass
{
    public static List<string>NameList = new List<string> ()
    {

       "Jimmy",
       "Jeffrey",
        "John"
    };

    
}
class program
{
    static void Main(string[]args)
    {
        var mylist = QuestionClass.NameList;
        mylist.ForEach(Console.WriteLine);
    }
}

