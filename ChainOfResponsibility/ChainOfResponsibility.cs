using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public abstract class Banknote
    {
        protected Banknote BankNote;
        public void NextOne(Banknote banknote)
        {
            this.BankNote = banknote;
        }
        public abstract Computation WithDraw(int money);
    }

    public class Computation
    {
        public int quantity { get; set; }
        public int remaining { get; set; }
        public int amount { get; set; }
    }

    class Money_200 : Banknote
    {
        public override Computation WithDraw(int money)
        {
            if (money >= 200)
            {
                return new Computation
                {
                    quantity = money / 200,
                    remaining = money % 200,
                    amount = 200
                };
            }
            else
            {
                return BankNote.WithDraw(money);
            }
        }
    }

    class Money_100 : Banknote
    {
        public override Computation WithDraw(int money)
        {
            if (money >= 100)
            {
                return new Computation
                {
                    quantity = money / 100,
                    remaining = money % 100,
                    amount = 100
                };
            }
            else
            {
                return BankNote.WithDraw(money);
            }
        }
    }

    class Money_50 : Banknote
    {
        public override Computation WithDraw(int money)
        {
            if (money >= 50)
            {
                return new Computation
                {
                    quantity = money / 50,
                    remaining = money % 50,
                    amount = 50
                };
            }
            else
            {
                return BankNote.WithDraw(money);
            }
        }
    }

    class Money_20 : Banknote
    {
        public override Computation WithDraw(int money)
        {
            if (money >= 20)
            {
                return new Computation
                {
                    quantity = money / 20,
                    remaining = money % 20,
                    amount = 20
                };
            }
            else
            {
                return BankNote.WithDraw(money);
            }
        }
    }

    class Money_10 : Banknote
    {
        public override Computation WithDraw(int money)
        {
            if (money >= 10)
            {
                return new Computation
                {
                    quantity = money / 10,
                    remaining = money % 10,
                    amount = 10
                };
            }
            else
            {
                return BankNote.WithDraw(money);
            }
        }
    }

    class Money_5 : Banknote
    {
        public override Computation WithDraw(int money)
        {
            if (money >= 5)
            {
                return new Computation
                {
                    quantity = money / 5,
                    remaining = money % 5,
                    amount = 5
                };
            }
            else
            {
                return BankNote.WithDraw(money);
            }
        }
    }

    class Money_1 : Banknote
    {
        public override Computation WithDraw(int money)
        {
            if (money >= 1)
            {
                return new Computation
                {
                    quantity = money / 1,
                    remaining = money % 1,
                    amount = 1
                };
            }
            else
            {
                return BankNote.WithDraw(money);
            }
        }
    }
}