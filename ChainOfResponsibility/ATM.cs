using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class ATM
    {
        Money_200 _200 = new Money_200();
        Money_100 _100 = new Money_100();
        Money_50 _50 = new Money_50();
        Money_20 _20 = new Money_20();
        Money_10 _10 = new Money_10();
        Money_5 _5 = new Money_5();
        Money_1 _1 = new Money_1();

        public List<Computation> MakeAdraft(int money)
        {
            Console.WriteLine("Total Amount: " + money);

            _200.NextOne(_100);
            _100.NextOne(_50);
            _50.NextOne(_20);
            _20.NextOne(_10);
            _10.NextOne(_5);

            var result = new Computation();
            var results = new List<Computation>();

            do
            {
                results.Add(result = _200.WithDraw(money));
                money = result.remaining;
            } while (result.remaining > 0);

            foreach (var s in results)
            {
                Console.WriteLine("Amount: " + s.amount + "\t Quantity: " + s.quantity);
            }

            return null;
        }
    }
}
