using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCLncPhnCrdt
{     
        public class Patient
        {
            public Plan Plan { get; set; }

            public Patient(int сode)
            {
                Plan = new Plan(сode);
            }
            public void SelectDoctor()
            {
                int code = Plan.Code;
                switch (code)
                {
                    case 1:
                        var surgeon = new Surgeon();
                        surgeon.Treat();
                        break;
                    case 2:
                        var dentist = new Dentist();
                        dentist.Treat();
                        break;
                    default:
                        var therapist = new Therapist();
                        therapist.Treat();
                        break;
                }
            }
        }
}
