namespace Exercise002
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Account heikkisAccount = new Account("Heikki's account", 1000.00);
            Account PersonalAccount = new Account("Personal account balance", 0.00);

            //Console.WriteLine("Intial state");
            // Console.WriteLine(heikkisAccount);
            // Console.WriteLine(heikkisSwissAccount);

            heikkisAccount.Withdrawal(100.0);
            Console.WriteLine("Heikki's account balance: " + heikkisAccount.balance);
            PersonalAccount.Deposit(100.0);
            Console.WriteLine("Personal account balance: " + PersonalAccount.balance);

            // Console.WriteLine("End state");
            // Console.WriteLine(heikkisAccount);
            // Console.WriteLine(heikkisSwissAccount);
        }
    }
}
