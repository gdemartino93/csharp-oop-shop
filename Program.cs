namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product nuovo = new Product(1, "asd", "asd",10,22);
            Console.WriteLine(nuovo.FullPrice());
        }
    }
}