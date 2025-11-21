using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificagit
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public double OrarioApertura { get; set; }
        public double OrarioChiusura { get; set; }
        public List<Libro> Libri { get; set; }

        public Biblioteca(string nome, string indirizzo, double orarioApertura, double orarioChiusura, List<Libro> libri)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            Libri = libri;
        }

        public void AggiungiLibro(Libro libro)
        {
            Libri.Add(libro);
        }

        public List<Libro> CercaTitolo(string titolo)
        {
            List<Libro> libritrovati = new List<Libro>();
            foreach (Libro libro in Libri)
            {
                if (libro.Titolo.Contains(titolo))
                {
                    libritrovati.Add(libro);
                }
            }
            if (libritrovati.Count == 0)
            {
                Console.WriteLine("mi dispiace non abbiamo trovato nessun libro col titolo inserito");
            }

            return libritrovati;
        }

        public List<Libro> CercaAutore(string autore)
        {
            List<Libro> autoritrovati = new List<Libro>();
            foreach (Libro libro in Libri)
            {
                if (libro.Autore.Contains(autore))
                {
                    autoritrovati.Add(libro);
                }
            }
            if (autoritrovati.Count == 0)
            {
                Console.WriteLine("nessun autore è stato trovato");
            }

            return autoritrovati;
        }

        public int NumLibri()
        {
            int num;
            num = Libri.Count();
            return num;
        }
    }
}
