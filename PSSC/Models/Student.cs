using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student
    {

        string nume_student;
        long cnp_sudent;
        string sectie_studnet;

        public Student(string numeStudent, long cnpStudent, string sectieStudent)
        {
            this.nume_student = numeStudent;
            this.cnp_sudent = cnpStudent;
            this.sectie_studnet = sectieStudent;
        }

        public string NumeStudent
        {
            get { return nume_student; }
            set { nume_student = value; }
        }

        public long CnpStudent
        {
            get { return cnp_sudent; }
            set { cnp_sudent = value; }
        }

        public string SectieStudent
        {
            get { return sectie_studnet; }
            set { sectie_studnet = value; }
        }
    }
}
