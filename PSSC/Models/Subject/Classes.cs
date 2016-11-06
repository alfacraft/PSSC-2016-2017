using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    class Classes
    {
        private List<Class> _classes;
        public ReadOnlyCollection<Class> Valori { get { return _classes.AsReadOnly(); } }

        internal Classes()
        {
            _classes = new List<Class>();
        }

        internal Classes(List<Class> cursuri)
        {
            Contract.Requires(cursuri != null, "List of classes");
            _classes = cursuri;
        }

        internal void AdaugaCurs(Class curs)
        {
            Contract.Requires(curs != null, "Class");
            _classes.Add(curs);
        }

        public override string ToString()
        {
            return _classes.Aggregate(new StringBuilder(), (builder, curs) =>
            {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(curs);
                return builder;
            }).ToString();
        }
    }
}