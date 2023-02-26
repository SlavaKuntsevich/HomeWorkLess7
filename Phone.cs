using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCLncPhnCrdt
{   
    public class Phone
    {
        public long number = 375441234567;
        public string model = "iPhone 12 256GB";
        public int weight = 166;
        public Phone(long number, string model, int weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }
        public Phone(long number, string model)
        {
            this.number = number;
            this.model = model;
        }
        public Phone() { }
        public void InitialParameters()
        {
            var format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Телефон {model}, номер {format}, вес {weight}г");
        }
        public void Parameters()
        {
            var format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Телефон {model}, номер {format}, вес {weight}г");
            Parameters2();
        }
        public void Parameters2()
        {
            string format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Телефон {model}, номер {format}");
        }
        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Вам звонит {name}");
        }
        public void GetNumber(long number)
        {
            string format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Номер телефона {format}");
        }
        public void ReceiveCall(string name, long number)
        {
            string format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Вам звонит {name}, номер {format}");
        }
        public void sendMessage(long number)
        {
            string format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Сообщение отправлено на номер {format}");
        }
    }
}



























































