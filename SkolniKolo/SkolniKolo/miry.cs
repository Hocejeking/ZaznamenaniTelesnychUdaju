using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkolniKolo
{

    

    public class miry
    {
       public int Vaha,Pas, Boky, Prsa, Stehna, Paze;
       public string Datum;

        public miry(DateTime datum,int vaha,int pas,int boky,int prsa, int stehna, int paze)
        {
            this.Datum = datum.Date.ToString();
            this.Vaha=vaha;
            this.Pas=pas;
            this.Boky=boky;
            this.Prsa=prsa;
            this.Stehna=stehna;
            this.Paze=paze;
        }
    }
}
