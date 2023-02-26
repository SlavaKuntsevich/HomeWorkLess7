using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCLncPhnCrdt
{
    public class CreditCard
    {
        public long cardNumber;
        public decimal balance;

        public CreditCard(long cardNumber, decimal balance)
        {
            this.cardNumber = cardNumber;
            this.balance = balance;
        }
        public void Reinforcement()
        {
            Console.WriteLine("Введите сумму для пополнения счета : ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            balance += +sum;
        }
        public void CashOut()
        {
            Console.WriteLine("Введите сумму для вывода : ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            balance = balance - sum;
        }
        public decimal Balance()
        {
            Console.WriteLine($"Баланс карты {cardNumber} : " + balance);
            return balance;
        }
    }
}
