using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompitoFormsJalba
{
    public class CChitarra : CStrumento, IComparable<CChitarra>
    {
        int qualitaSuono;

        public CChitarra(int qualitaSuono) : base("STRUM")
        {
            this.qualitaSuono = qualitaSuono;
        }

        public override string play()
        {
            Random rand = new Random();
            string r;

            switch (rand.Next(3)) 
            {
                case 0:
                    r = "Suona accordi";
                    break;
                case 1:
                    r = "Fa assoli";
                    break;
                case 2:
                    r = "Altro";
                    break;
                default:
                    r = "Suona male";
                    break;
            }

            return r;
        }

        //metodo makeSound() già presente nella classe CStrumento

        public int CompareTo(CChitarra other) 
        {
            return (this.qualitaSuono > other.qualitaSuono) ? 1 : //primo precede
                   (this.qualitaSuono == other.qualitaSuono ? (this.volume > other.volume ? 1 : (this.volume == other.volume ? 0 : -1)) : //se uguale confronta il volume
                   -1); //primo segue
        }

        public override string toString()
        {
            return $"Chitarra: qualità suono {qualitaSuono}, volume {volume}.";
        }
    }
}
