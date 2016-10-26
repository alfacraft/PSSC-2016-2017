using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{}
    public class Decanat
    {
        List<Models.Disciplina> disciplina = new List<Models.Disciplina>();
        List<Models.Student> student = new List<Models.Student>();
        List<Models.Profesor> profesor = new List<Models.Profesor>();

        public Decanat (List<Models.Disciplina> disciplina, List<Models.Profesor> profesor, List<Models.Student> student)
        {
            this.disciplina = disciplina;
            this.student = student;
            this.profesor = profesor;
        }

        private List<Models.Disciplina> Disciplina
        {
            get{return disciplina;}
            set{disciplina = value;}
        }

        private List<Models.Student> Student
        {
            get{return student;}
            set{student = value;}
        }

        private List<Models.Profesor> Profesor
        {
            get{return profesor;}
            set{profesor = value;}
        }
    }
}

