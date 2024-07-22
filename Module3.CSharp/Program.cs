namespace Module3.CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            myName = "Pavel";

            Console.WriteLine(myName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 26 лет");
            Console.WriteLine("\t Моя имя \n {0}", myName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");
        }
    }
}