using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_gyakorlas
{
    internal class Haromszog
    {
        //field (mező)
        int aOldal, bOldal, cOldal;
        public static int darab = 0;

        //konstruktor
        public Haromszog() 
        {
            darab++;
        }

        //paraméteres konstruktor
        public Haromszog(int aOldal, int bOldal, int cOldal)
        {
            this.aOldal = aOldal;
            this.bOldal = bOldal;
            this.cOldal = cOldal;
            darab++;
        }

        //property
        public int AOldal { get => aOldal; set => aOldal = value; }
        public int BOldal { get => bOldal; set => bOldal = value; }
        public int COldal { get => cOldal; set => cOldal = value; }

        //metódus
        public bool SzerkeszthetoM()
        {
            if (aOldal + bOldal > cOldal && aOldal + cOldal > bOldal)
            {
                return true;
            }
            else return false;
        }

        public int HaromszogKeruleteM()
        {
            if (SzerkeszthetoM()) return aOldal + bOldal + cOldal;
            else return -1;
        }

        public string isDerekszoguM()
        {
            double aNegyzet = Math.Pow(aOldal, 2);
            double bNegyzet = Math.Pow(bOldal, 2);
            double cNegyzet = Math.Pow(cOldal, 2);

            if (aNegyzet + bNegyzet == cNegyzet || aNegyzet + cNegyzet == bNegyzet || cNegyzet + bNegyzet == aNegyzet)
            {
                return "A háromszög derékszögű.";
            }
            else return "A háromszög nem derékszögű.";
        }

        public double HaromszogTeruleteM()
        {
            if (SzerkeszthetoM())
            {
                double s = (aOldal + bOldal + cOldal) / 2.0;
                return Math.Sqrt(s * (s - aOldal) * (s - bOldal) * (s - cOldal));
            }
            else return -1;
        }

        //property
        public int HaromszogKeruleteP
        {
            get
            {
                if (SzerkeszthetoP)
                {
                    return aOldal + bOldal + cOldal;
                }
                else return -1;
            }
        }

        bool SzerkeszthetoP
        {
            get
            {
                if (aOldal + bOldal > cOldal && aOldal + cOldal > bOldal)
                {
                    return true;
                }
                else return false;
            }
        }

        public string isDerekszoguP
        {
            get
            {
                double aNegyzet = Math.Pow(aOldal, 2);
                double bNegyzet = Math.Pow(bOldal, 2);
                double cNegyzet = Math.Pow(cOldal, 2);

                if (aNegyzet + bNegyzet == cNegyzet || aNegyzet + cNegyzet == bNegyzet || cNegyzet + bNegyzet == aNegyzet)
                {
                    return "A háromszög derékszögű.";
                }
                else return "A háromszög nem derékszögű.";
            }
        }

        public double HaromszogTeruleteP
        {
            get
            {
                if (SzerkeszthetoP)
                {
                    double s = (aOldal + bOldal + cOldal) / 2.0;
                    return Math.Sqrt(s * (s - aOldal) * (s - bOldal) * (s - cOldal));
                }
                else return -1;
            }
            
        }
    }
}
