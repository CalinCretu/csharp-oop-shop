namespace csharp_oop_shop
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Prodotto mouse = new Prodotto( "Occhiali da sole", "Occhiali con lenti scure", 49.90m, 22 );

            // Accesso alle proprietà del prodotto
            Console.WriteLine("Codice: " + mouse.Codice);
            Console.WriteLine("Nome: " + mouse.Nome);
            Console.WriteLine("Descrizione: " + mouse.Descrizione);
            Console.WriteLine("Prezzo: " + mouse.Prezzo);
            Console.WriteLine("IVA: " + mouse.Iva);
            // Test dei metodi
            Console.WriteLine("Prezzo base: " + mouse.PrezzoBase());
            Console.WriteLine("Prezzo con IVA: " + mouse.PrezzoConIva());
            Console.WriteLine("Nome esteso: " + mouse.NomeEsteso());

        } 
    }

    public class Prodotto
    {
        // Proprietà del prodotto
        public int Codice { get; private set; } // Accessibile solo in lettura
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public int Iva { get; set; }

        // Costruttore per inizializzare le proprietà del prodotto
        public Prodotto( string nome, string descrizione, decimal prezzo, int iva )
        {
            Codice = GeneraCodiceRandom();
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;
        }

        // Metodo per generare un codice random
        private int GeneraCodiceRandom()
        {
            Random random = new Random();
            return random.Next( 1, 100000 ); // Genera un numero intero casuale
        }

        // Metodo per ottenere il prezzo base
        public decimal PrezzoBase()
        {
            return Prezzo;
        }

        // Metodo per calcolare il prezzo totale, compreso di IVA
        public decimal PrezzoConIva()
        {
            return Prezzo + ( (Prezzo / 100) * Iva);
        }

        // Metodo per ottenere il nome esteso concatenando codice + nome
        public string NomeEsteso()
        {
            return Codice + " " + Nome;
        }
    }
}
