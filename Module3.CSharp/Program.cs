namespace Module3.CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            myName = "Pavel";
            byte myAge = 26;
            bool haveIpet = false;
            double myShoeSize = 42.5;


            Console.WriteLine(myName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне {0}", myAge + " лет");
            Console.WriteLine("\t Моя имя \n {0}", myName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");
            Console.WriteLine("Есть ли у меня питомец? " +  haveIpet);
            Console.WriteLine("Мой размер обуви: " +  myShoeSize);



        }
    }
}