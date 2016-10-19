using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Disciplina:Profesor
    {

        protected int valoare_credite;
        protected int evaluare_materie;  // 0 - Distribuit / 1 - Examen final

       public void setCredite(int c)
        {
            valoare_credite = c;
        }

        public void setEvaluare(int e)
       {
           evaluare_materie = e;
       }
    }
}
