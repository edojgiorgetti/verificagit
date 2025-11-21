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
    }
}
