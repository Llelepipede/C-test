using System;
using System.Collections.Generic;

public class Program
{
    static List<char> alphabet = new List<char>
    {
        'a','b','c','d','e','f','g','h','i','j','k','l','m',
        'n','o','p','q','r','s','t','u','v','w','x','y','z'
    };

    public static void Main()
    {
        AlgoTest(MyNameIs);
        Console.ReadLine();
    }

    public static string MyNameIs(string name)
    {
        string ret = "";
        foreach (char letter in name)
        {
            for (int i = 0; i < alphabet.Count; i++)
            {
                if (letter == alphabet[i])
                {
                    ret += i.ToString();
                }
            }
        }
        return ret;


        // myNameIs("Ahmed") should return  '071243'
        // myNameIs("Dorlean") return 31417114013
        // myNameIs("a") return  0
        // myNameIs("Sandrine") return 180133178134


    }

    public static void AlgoTest(Func<string, string> func)
    {
        if (func("AB") == "01")
        {
            Console.WriteLine("Success");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}