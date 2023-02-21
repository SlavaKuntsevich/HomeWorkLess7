using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeWorkCLncPhnCrdt.Phone1;

namespace HomeWorkCLncPhnCrdt
{
    public class Class
    {
        static void Main(string[] args)
        {   //TASK 1
            Phone1 result = new Phone1();
            result.ShowCharacteristics1();
            Phone2 result2 = new Phone2();
            result2.ShowCharacteristics2();
            Phone3 result3 = new Phone3();
            result3.ShowCharacteristics3();
            Phone1 call = new Phone1();
            call.ReceiveCall("Клим Саныч СТО");
            Phone2 call2 = new Phone2();
            call2.ReceiveCall("Анжела секретарь");
            Phone3 call3 = new Phone3();
            call3.ReceiveCall("Олег сосед");
            Phone1 number = new Phone1();
            number.GetNumber();
            Phone2 number2 = new Phone2();
            number2.GetNumber2();
            Phone3 number3 = new Phone3();
            number3.GetNumber3();
            Phone1 parameters3 = new Phone1(375441234567, "IPhone 7 ", 138);
            parameters3.ShowCharacteristics1();
            Phone1 parameters2 = new Phone1(375441234567, "IPhone 7 ");
            parameters2.ShowCharacteristics2();
            Phone1 callNumNumb = new Phone1();
            callNumNumb.ReceiveCall("Анжела секретарь", 375291234567);
            Phone1 message = new Phone1();
            message.SendMessage(375331234567);
            //TASK2
            Patient patient = new Patient();
            patient.Plan(1);
            patient.Plan(2);
            patient.Plan(3);
            //TASK3
            CreditCard creditCard1 = new CreditCard(5323080012345678, 5600);
            CreditCard creditCard2 = new CreditCard(9112001012345678, 3800);
            CreditCard creditCard3 = new CreditCard(0010200030458540, 360);
            creditCard1.Balance();
            creditCard1.Reinforcement();
            Console.WriteLine("$$$$$$$$$$$$$");
            creditCard2.Balance();
            creditCard2.Reinforcement();
            Console.WriteLine("$$$$$$$$$$$$$");
            creditCard3.Balance();
            creditCard3.CashOut();
            Console.WriteLine("$$$$$$$$$$$$$");
            creditCard1.Balance();
            creditCard2.Balance();
            creditCard3.Balance();
        }
    }
}
