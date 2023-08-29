using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Situatii_Note_Studenti
{


    internal class Disciplina : IAveregeable, ICloneable<Disciplina>
    {
        private int id;
        private string nume;
        private int credite;
        private float[] note;


        public Disciplina()
        {
        }

        public Disciplina(int id,string nume, int credite, float[] note)
        {
            this.id = id;
            this.nume = nume;
            this.credite = credite;
            this.note = new float[note.Length];
            for (int i = 0; i < note.Length; i++)
            {
                this.note[i] = note[i];
            }
        }

        public int Id { get => id; set => id = value; }

        public string Nume { get => nume; set => nume = value; }
        public int Credite { get => credite; set => credite = value; }
        public float[] Note { get => note; set => note = value; }

        public float AverageNote()
        {
            float medie = 0.0f;
            for (int i = 0; i < this.Note.Length; i++)
            {
                medie += this.Note[i];
            }

            return medie / this.Note.Length;
        }
        public float AverageNoteCredite()
        {

            float medie = 0.0f;
            medie=AverageNote()*credite;
            return medie;
        }


        public float this[int x] 
        {
            get => Note[x];
            set => Note[x] = value;
        }

        public static Disciplina operator +(Disciplina d, int notaNoua)
        {
            float[] noteNoi = new float[d.note.Length + 1];
            for (int i = 0; i < d.note.Length; i++)
            {
                noteNoi[i] = d.note[i];
            }
            noteNoi[noteNoi.Length - 1] = notaNoua;
            d.note = noteNoi;
            return d;
        }
        public override string ToString()
        {
            string afisare = "\nDisciplina: " + nume.ToString() + ", credite: " + credite.ToString()+"\nNote:  ";
                foreach(int nota in note)
            {
                
                afisare += nota+" ";
            }
               
            return afisare;
        }
        public Disciplina Clone()
        {
            Disciplina nou = (Disciplina)this.MemberwiseClone();
            float[] noteClonate = (float[])this.note.Clone();
            nou.note = noteClonate;
            return nou;
        }
    }
}
