using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    internal class Fraction : InterfacComperable1
    {
        private int nom;
        private int denom;
        
        public Fraction(int nom , int denom)
        {
            this.nom = nom; 
            this.denom = denom; 
        }
        public int GetNom() { return nom; }
        public int GetDenom() { return denom; }
        public void SetNom(int nom) { this.nom = nom; }
        public void SetDenom(int denom) { this.denom = denom; }

        public bool isEquel(object obj)
        {
            if(!(obj is Fraction)) { return false; }
            Fraction f = (Fraction)obj;
            return (f.nom == nom && f.denom == denom);
        }
        public bool isGreater(object obj)
        {
            return false;
        }
        public override string ToString()
        {
            return "nom is: " + nom + "denom is: " + denom;
        }

    }
}
