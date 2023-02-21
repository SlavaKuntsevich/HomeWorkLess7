using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCLncPhnCrdt
{   //TASK 1
    public class Phone1
    {
        public long number = 375441234567;
        public string model = "Iphone 12";
        public double weight = 163.5;
        public int result;
        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Вам звонит {name}");
        }
        public void ShowCharacteristics1()
        {
            string format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Телефон {model}, номер {format}, вес {weight}г");
        }
        public void ShowCharacteristics2()
        {
            string format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Телефон {model}, номер {format}");
        }
        public void ShowCharacteristics3()
        {
            string format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Телефон {model}, номер {format}");
        }        
        public void GetNumber()
        {
            string format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Номер телефона {format}");
        }
        public Phone1(long number, string model, double weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }
        public Phone1(long number, string model)
        {
            this.number = number;
            this.model = model;
        }
        public Phone1() { }
        public void SendMessage(long number)
        {
            string format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"сообщение отправлено на номер {format}");
        }
        public void ReceiveCall(string name, long number)
        {
            string format = string.Format("{0:+### (##) ###-##-##}", number);
            Console.WriteLine($"Вам звонит {name}, номер {format}");
        }
        public class Phone2
        {
            public long number = 375291234567;
            public string model = "Nokia 3310";
            public double weight = 150;
            public int result;
            public void ShowCharacteristics2()
            {
                string format = string.Format("{0:+### (##) ###-##-##}", number);
                Console.WriteLine($"Телефон {model}, номер {format},вес {weight} г ");
            }
            public void ReceiveCall(string name)
            {
                Console.WriteLine($"Вам звонит {name}");
            }
            public void GetNumber2()
            {
                string format = string.Format("{0:+### (##) ###-##-##}", number);
                Console.WriteLine($"Номер телефона {format}");
            }
        }
        public class Phone3
        {
            public long number = 375331234567;
            public string model = "Domofon 3000 256Flats";
            public double weight = 3000;
            public int result;
            public void ShowCharacteristics3()
            {
                string format = string.Format("{0:+### (##) ###-##-##}", number);
                Console.WriteLine($"Телефон {model}, номер {format}, вес {weight}г");
            }
            public void ReceiveCall(string name)
            {
                Console.WriteLine($"Вам звонит {name}");
            }
            public void GetNumber3()
            {
                string format = string.Format("{0:+### (##) ###-##-##}", number);
                Console.WriteLine($"Номер телефона {format}");
            }
        }
    }    
}



























































