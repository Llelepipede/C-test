using System;

public class Program
{
    public static void Main()
    {
       Console.WriteLine(ConvertToUpper("bonjour1B23"));
    }

    public static string ConvertToUpper(string text)
    {
       string ret = "";

       foreach (char letter in text)
       {
		   char real = letter;
		   if (Convert.ToInt32(letter) >= 97 && Convert.ToInt32(letter) <= 122)
		   {
			    real = Convert.ToChar(Convert.ToInt32(letter) - 32);
		   }
            ret += real;
       }

       return ret;
    }
}