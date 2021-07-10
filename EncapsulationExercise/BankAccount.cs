using System;
namespace EncapsulationExercise
{
    public class BankAccount
    {
        
        private double balance;

       
        public BankAccount()
        {
            balance = 0;     
        }


        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void GetBalance()
        {
            Console.WriteLine($"${balance}");
        }
    }
}
