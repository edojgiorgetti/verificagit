using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificagit
{
    public class Libro
    {
        private string _titolo;
        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }

        private string _autore;
        public string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }

        private DateTime _datapubblicazione;
        public DateTime Datapubblicazione
        {
            get { return _datapubblicazione; }
            set { _datapubblicazione = value; }

        }

        private string _editore;
        public string Editore
        {
            get { return _editore; }
            set { _editore = value; }
        }

        private int _numpagine;
        public int Numpagine
        {
            get { return _numpagine; }
            set { _numpagine = value; }

        }

        public Libro(string autore, string titolo, string editore, DateTime datapubblicazione, int numpagine)
        {
            Autore = autore;
            Titolo = titolo;
            Editore = editore;
            Datapubblicazione = datapubblicazione;
            Numpagine = numpagine;
        }

        public override string ToString()
        {
            return $"Titolo libro: {Titolo}, Autore: {Autore}, Editore: {Editore}, Data di pubblicazione: {Datapubblicazione}, Numero di pagine: {Numpagine}";
        }

        public string ReadingTime(int npagine)
        {
            string orelettura;
            if (npagine < 100)
            {
                orelettura = "tempo di lettura del libro: 1 ora";
            }
            else if(npagine < 200)
            {
                orelettura = "tempo di lettura del libro compreso tra una e due ore";
            }
            else
            {
                orelettura = "tempo di lettura del libro superiore a 2 ore";
            }

            return orelettura ;
        }

    }
}
