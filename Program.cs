﻿namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product nuovo = new Product("asd","asd",10,22);
            Console.WriteLine(nuovo.FullPrice());
            Console.WriteLine(nuovo.CodiceProdotto);
            Console.WriteLine(nuovo.Prezzo);
            nuovo.FullName();
            Console.WriteLine(nuovo.PadLeft(nuovo.CodiceProdotto));
        }
    }
}