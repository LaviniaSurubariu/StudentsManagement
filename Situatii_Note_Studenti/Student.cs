using System;
using System.Collections;
using System.Collections.Generic;

namespace Situatii_Note_Studenti
{
    public interface ICloneable<T>
    {
        T Clone();
    }
    internal class Student : ICloneable<Student>, IEnumerator, IEnumerable, IAveregeable, IComparable<Student>
    {
        private int id;
        private string nume;
        private string prenume;
        private int an;
        private int grupa;
        private List<Disciplina> discipline = new List<Disciplina>();
        

        int index = -1;
        public Student()
        {
        }
        public Student(int id, string nume, string prenume, int an, int grupa)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.an = an;
            this.grupa = grupa;
           
        }
        public Student(int id,string nume, string prenume, int an, int grupa, List<Disciplina> discipline)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.an = an;
            this.grupa = grupa;
            foreach(Disciplina disciplina in discipline)
            {
                this.discipline = discipline;

            }
        }
        public int Id { get => id; set => id = value; }

        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public int An { get => an; set => an = value; }
        public int Grupa { get => grupa; set => grupa = value; }
        internal List<Disciplina> Discipline { get => discipline; set => discipline = value; }


        public IEnumerator GetEnumerator() { return (IEnumerator)this; }
        public bool MoveNext() { index++; return index < discipline.Count; }

        public void Reset() { index = -1;}

        public Object Current
        {
            get { return discipline[index]; }
            
        }
       
        public override string ToString()
        {
            string mesaj = "Studentul " + nume + " " + prenume + " din anul " + an +
                ", grupa: " + grupa + "\n";

            if(discipline != null)
            {
                foreach (Disciplina disclina in Discipline)
                {
                    mesaj += disclina.ToString();
                }
            }
                return mesaj;



        }

        public Student Clone()
        {
            Student s = (Student)this.MemberwiseClone();
            List<Disciplina> d = s.discipline.ConvertAll(disciplina => disciplina.Clone());
            s.discipline = d;
            return s;
        }

        public float AverageNote()
        {
            float medie = 0.0f;
            int sumCredite = 0;
            foreach (Disciplina disciplina in discipline)
            {
                medie+= disciplina.AverageNoteCredite();
                sumCredite += disciplina.Credite;
            }
            return medie/sumCredite;
        }

        public int CompareTo(Student other)
        {
            if(this.AverageNote()>other.AverageNote())return -1;
            else if(this.AverageNote()==other.AverageNote()) return 0;
            else return 1;
        }

        public static Student operator ++(Student s)
        {
            s.an++;
            return s;
        }
    }


}
