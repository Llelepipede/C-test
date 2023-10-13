using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Entrez un nombre: ");
        if(int.TryParse(Console.ReadLine(), out int number))
        {
           if(number%2 == 0){
                Console.Write("even");
           }else{
                Console.Write("odd");
           }
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre entier valide.");
        }
    }
}