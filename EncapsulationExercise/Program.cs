using System;

namespace EncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            myAccount.Deposit(450);
            myAccount.GetBalance();
            myAccount.Deposit(375);
            myAccount.GetBalance();

        }
    }
}
