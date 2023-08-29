using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Situatii_Note_Studenti
{
    internal class Centralizator : IAveregeable, IEnumerator, IEnumerable
    {
        private List<Student> studenti;
        int index = -1;
        public Centralizator()
        {
        }

        public Centralizator(List<Student> studenti)
        {
            foreach (Student student in studenti)
            {
                this.studenti = studenti;
            }
        }

        internal List<Student> Studenti { get => studenti; set => studenti = value; }


        public IEnumerator GetEnumerator() { return (IEnumerator)this; }
        public bool MoveNext() { index++; return index < studenti.Count; }
        public void Reset() { index = -1; }
        public Object Current
        {
            get { return studenti[index]; }
        }

        public float AverageNote()
        {
            throw new NotImplementedException();
        }

       
    }
}
