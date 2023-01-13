using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPukol6
{
    internal class Osoba
    {
        protected string jmeno;
        protected string prijmeni;
        protected double hmotnost;
        protected double vyska;

        public Osoba(string jmeno,string prijmeni,double hmotnost, double vyska) {

            this.jmeno = jmeno;
            this.prijmeni= prijmeni;
            this.hmotnost= hmotnost;
            this.vyska= vyska;
        }

        string Jmeno
        {
            get; set;
        }
        string Prijmeni { get; set; }

        double Hmotnost {
            get { return hmotnost; } 
            set
            {
                if (value > 0 && value <= 300)
                {
                    hmotnost= value;
                }
                else
                {
                    MessageBox.Show("Hmotnot mimo rozsah");
                }
            }
        }

        double Vyska
        {
            get { return vyska; }
            set
            {
                if(value > 3)
                {
                    vyska = value / 100;
                }
                else
                {
                    vyska = value;
                }
            }
        }

        public double BMI()
        {
            return (hmotnost / (vyska * vyska));
        }

        public override string ToString()
        {
            return jmeno + " " + prijmeni + " s vahou " + hmotnost + "kg a vyskou " + vyska + "m\n"+ "BMI: " + Math.Round(BMI(),2);
        }
    }
}
