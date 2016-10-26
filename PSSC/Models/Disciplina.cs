using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum EvaluareExamen
    {
        distribuit, examen
    }
    public class Disciplina
    {
        string denumire_materie;
        int credite_materie;
        int an_studiu;
        EvaluareExamen evaluare_examen;

        public Disciplina(string denumireMaterie, int crediteMaterie, int anStudiu)
        {
            this.denumire_materie = denumireMaterie;
            this.credite_materie = crediteMaterie;
            this.an_studiu = anStudiu;
        }

        public string DenumireMaterie
        {
            get { return denumire_materie; }
            set { denumire_materie = value; }
        }

        public int CrediteMaterie
        {
            get { return credite_materie; }
            set { credite_materie = value; }
        }

        public int AnStudiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }

        public EvaluareExamen Examen
        {
            get { return evaluare_examen; }
            set { evaluare_examen = value; }
        }
    }
}
