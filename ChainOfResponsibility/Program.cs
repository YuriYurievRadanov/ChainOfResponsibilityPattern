using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainOfResponsibility.ATM b = new ChainOfResponsibility.ATM();
            b.MakeAdraft(1385);

            Console.ReadKey();
        }
    }
}
