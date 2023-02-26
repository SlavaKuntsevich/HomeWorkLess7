using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCLncPhnCrdt
{
    public class Dentist : Doctor
    {
        public override void Treat()
        {
            Console.WriteLine("Дантист лечит");
        }
    }
}
