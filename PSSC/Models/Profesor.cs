using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Profesor:Decanat
    {
       public void setpoportie(float prop)
       {
           proportie = prop;
       }
       protected float proportie;
    }
}
