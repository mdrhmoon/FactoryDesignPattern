using System;

namespace ClientApplicationFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            CardFactory factory = null;
            Console.WriteLine("Enter the card type you would like to visit: ");
            string car = Console.ReadLine();

            switch (car.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 0);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below: \n");
            Console.WriteLine($"Card Type: {creditCard.CardType}\nCredit Limit: {creditCard.CreditLimit}\nAnnual Charge: {creditCard.AnnualCharge}");
            Console.ReadKey();
        }
    }
}
