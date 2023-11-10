namespace Exercise001
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        { // DO NOT TOUCH THE OTHER FILE!
            // Do your code here!
            Account heikkisAccount = new Account("Heikki's account", 100.00);
            // Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

            // Console.WriteLine("Intial state");
            // Console.WriteLine(heikkisAccount);
            // Console.WriteLine(heikkisSwissAccount);

            //heikkisAccount.Withdrawal(100);
            heikkisAccount.Deposit(20.0);
            Console.WriteLine(heikkisAccount.balance);
            // heikkisSwissAccount.Deposit(200);
            // Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.balance);

            // Console.WriteLine("End state");
            // Console.WriteLine(heikkisAccount);
            // Console.WriteLine(heikkisSwissAccount);
        }
    }
}
