using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Profesor
    {

       string nume_profesor;
       long cnp_profesor;
       string catedra_profesor;

       public Profesor(string numeProfesor, long cnpProfesor, string catedraProfesor)
       {
           this.nume_profesor = numeProfesor;
           this.cnp_profesor = cnpProfesor;
           this.catedra_profesor = catedraProfesor;
       }

       public string NumeProfesor
       {
           get { return nume_profesor; }
           set { nume_profesor = value; }
       }

       public long CnpProfesor
       {
           get { return cnp_profesor;}
           set { cnp_profesor = value; }
       }

       public string CatedraProfesor
       {
           get { return catedra_profesor; }
           set { catedra_profesor = value; }
       }
    }
}
