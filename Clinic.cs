using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCLncPhnCrdt
{
    public class Surgeon
    {
        public static string Heal()
        {
            string healPatient = "Вам назначен хирург, приходите через год";
            Console.WriteLine(healPatient);
            return healPatient;
        }
    }
    public class Therapist
    {
        public static string Heal()
        {
            string healPatient = "Вам назначен терапевт, приходите завтра";
            Console.WriteLine(healPatient);
            return healPatient;
        }
    }
    public class Dentist
    {
        public static string Heal()
        {
            string healPatient = "Вам назначен дантист, приходите сегодня";
            Console.WriteLine(healPatient);
            return healPatient;
        }
    }
    public class Patient
    {
        public void Plan(int num)
        {
            if (num == 1)
            {
                Surgeon.Heal();
            }
            if (num == 2)
            {
                Dentist.Heal();
            }
            if (num != 1 && num != 2)
            {
                Therapist.Heal();
            }
        }
    }
}
