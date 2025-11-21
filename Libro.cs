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

    }
}
