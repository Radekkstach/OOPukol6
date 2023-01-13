using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPukol6
{
    internal class Pacient : Osoba
    {
        private double obvodPasu;
        public Pacient(string jmeno, string prijmeni, double hmotnost, double vyska,double obvodPasu) : base(jmeno,prijmeni,hmotnost,vyska) 
        {
            this.obvodPasu = obvodPasu;
                    
        }
        double ObvodPasu { get; set; }

        public double ABSI()
        {
            return (obvodPasu / (Math.Pow(BMI(), (double)2 / 3) * Math.Pow(vyska, (double)1 / 2)));
        }
               

        public override string ToString()
        {
            return base.ToString() + "\nABSI: " + Math.Round(ABSI(),3);
        }
    }
}
