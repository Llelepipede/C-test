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
            char real = Convert.ToChar(Convert.ToInt32(letter) + 32);
            Console.WriteLine(real);
            for (int i = 0; i < alphabet.Count; i++)
            {
                if (real == alphabet[i])
                {
                    ret += i.ToString();
                }
            }
        }
		Console.WriteLine(ret);
        return ret;
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