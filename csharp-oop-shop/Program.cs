namespace csharp_oop_shop
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Prodotto occhiali = new Prodotto( "Occhiali", "Occhiali da sole con lenti Blu", 49.90m, 22 );

            // Accesso alle proprietà del prodotto
            Console.WriteLine("Codice: " + occhiali.Codice);
            Console.WriteLine("Nome: " + occhiali.Nome);
            Console.WriteLine("Descrizione: " + occhiali.Descrizione);
            Console.WriteLine("Prezzo: " + occhiali.Prezzo);
            Console.WriteLine("IVA: " + occhiali.Iva);
            // Test dei metodi
            Console.WriteLine("Prezzo base: " + occhiali.PrezzoBase());
            Console.WriteLine("Prezzo con IVA: " + occhiali.PrezzoConIva());
            Console.WriteLine("Nome esteso: " + occhiali.NomeEsteso());

            // Creazione dell'array dei prodotti
            Prodotto[] listaProdotti = new Prodotto[3]; // 3 prodotti che potremmo trovare nel negozio

            // Inserimento dei prodotti nell'array
            listaProdotti[0] = new Prodotto("Mouse", "Mouse ottico wireless", 29.99m, 22);
            listaProdotti[1] = new Prodotto("Tastiera", "Tastiera meccanica RGB", 79.99m, 22);
            listaProdotti[2] = new Prodotto("Cuffie", "Cuffie stereo con cancellazione del rumore", 149.99m, 22);

            // Stampare l'elenco dei prodotti previsti nel negozio
            Console.WriteLine("\nElenco dei prodotti previsti nel negozio:");
            foreach (Prodotto prodotto in listaProdotti)
            {
                Console.WriteLine("\nNome: " + prodotto.Nome);
                Console.WriteLine("Descrizione: " + prodotto.Descrizione);
                Console.WriteLine("Prezzo: " + prodotto.Prezzo);
                Console.WriteLine("IVA: " + prodotto.Iva);
                // Test dei metodi
                Console.WriteLine("Prezzo base: " + prodotto.PrezzoBase());
                Console.WriteLine("Prezzo con IVA: " + prodotto.PrezzoConIva());
                Console.WriteLine("Nome esteso: " + prodotto.NomeEsteso());
            }
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
            return random.Next( 1, 10000000 ); // Genera un numero intero casuale
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
            return CodiceConPadding() + " " + Nome;
        }

        // Metodo per restituire il codice con padding
        public string CodiceConPadding()
        {
            return Codice.ToString().PadLeft(8, '0');
        }
    }
}
