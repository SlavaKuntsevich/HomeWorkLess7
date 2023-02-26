using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeWorkCLncPhnCrdt.Phone;

namespace HomeWorkCLncPhnCrdt
{
    public class Program
    {
        static void Main(string[] args)
        {   //TASK 1
            var initialPhone = new Phone();
            initialPhone.InitialParameters();
            var secondPhone = new Phone(375332468135, "Iphone 5S 32Gb", 133);
            secondPhone.InitialParameters();
            var thirdPhone = new Phone(375440501743, "IPhone 6S 64Gb", 138);
            thirdPhone.InitialParameters();
            var call = new Phone();
            call.ReceiveCall("Андрей");
            var number = new Phone();
            number.GetNumber(375333332244);
            var parameters3 = new Phone(375291170000, "Iphone 7 Plus 128Gb", 180);
            parameters3.Parameters();
            var callNumNumb = new Phone();
            callNumNumb.ReceiveCall("Сергей", 375296746765);
            var message = new Phone();
            message.sendMessage(375254757556);
            Console.ReadKey();

            //TASK2
            Console.WriteLine();
            var patient = new Patient(1);
            patient.SelectDoctor();
            Console.ReadKey();
            //TASK3
            CreditCard creditCard1 = new CreditCard(5323080012345678, 5600);
            CreditCard creditCard2 = new CreditCard(9112001012345678, 3800);
            CreditCard creditCard3 = new CreditCard(0010200030458540, 360);
            creditCard1.Balance();
            creditCard1.Reinforcement();
            Console.WriteLine("_____________________");
            creditCard2.Balance();
            creditCard2.Reinforcement();
            Console.WriteLine("_____________________");
            creditCard3.Balance();
            creditCard3.CashOut();
            Console.WriteLine("_____________________");
            creditCard1.Balance();
            creditCard2.Balance();
            creditCard3.Balance();
        }
    }
}
