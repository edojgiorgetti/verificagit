namespace verificagit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Manzoni", "I promessi sposi", "zanichelli", new DateTime(1900, 10, 08), 800);
            Libro libro2 = new Libro("Boccaccio", "La bella addormentata nel bosco", "zanichelli", new DateTime(1901, 11, 12), 500);

            int scelta;
            int scelta2;
            do
            {
                Console.WriteLine("Se vuoi aggiungere un libro alla biblioteca clicca 1, se vuoi cercare un libro per titolo digita 2, se vuoi cercare i libri di un autore digita 3, se vuoi contare il numero di libri nella biblioteca digita 4 ");
                scelta2 = int.Parse(Console.ReadLine());
                switch (scelta2)
                {
                    case 1:
                    //aggiunge il libro
                    case 2:
                    //richiamo il metodo per cercare il libro per titolo
                    case 3:
                    //richiamo il metoto per trovare i libri di un autore
                    case 4:
                        //richiamo il metodo che restituisce il numero di libri della biblioteca

                }

                // chiedo all'utente se vuole continuare a gestire la sua libreria o vuole fermarsi
                Console.WriteLine("se vuoi continuare digita 1 altrimenti 0");
                scelta = int.Parse(Console.ReadLine());
            } while (scelta == 1);
        }
    }
}
