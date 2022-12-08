// See https://aka.ms/new-console-template for more information
//Code to iterate through 
//list with out for each or for loop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;

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
    static void Main(string[] args)
    {
        var mylist = QuestionClass.NameList;
        mylist.ForEach(Console.WriteLine);

        dynamic ec = new TESTModule1(7);
            }
}

class TESTModule1
{
    public  TESTModule1(dynamic MyValue)
    {
        dynamic answer = "";
        
        var returnType = MyValue.GetType();

        switch (returnType)
        {

            case "Int32":

                if (1 >= MyValue <= 4)
                {
                    answer = (2 * MyValue);
                }
                else if (MyValue > 1)
                {
                    answer = "Not a proper intiger";

                }
                else
                {
                    answer = (3 * MyValue);

                }
                break;


            case "Double":

                if (MyValue is (1.0) or (2.0))
                {
                    answer = "(3.0)";

                }

                break;

            case "String":

                answer = MyValue.ToString.UpperCase();
                break;

            default:

                answer = MyValue.ToString();
                break;
            
        }
         

    }
    
    
}
   


    



