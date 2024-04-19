namespace csharp_oop_shop
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Prodotto mouse = new Prodotto(1, "Occhiali da sole", "Occhiali con lenti scure", 49.90m, 58.50m);

            // Accesso alle proprietà del prodotto
            Console.WriteLine("Codice: " + mouse.Codice);
            Console.WriteLine("Nome: " + mouse.Nome);
            Console.WriteLine("Descrizione: " + mouse.Descrizione);
            Console.WriteLine("Prezzo: " + mouse.Prezzo);
            Console.WriteLine("IVA: " + mouse.Iva);

        } 
    }

    public class Prodotto
    {
        // Proprietà del prodotto
        public int Codice { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public decimal Iva { get; set; }

        // Costruttore per inizializzare le proprietà del prodotto
        public Prodotto(int codice, string nome, string descrizione, decimal prezzo, decimal iva)
        {
            Codice = codice;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;
        }

        // Metodo per calcolare il prezzo totale, compreso di IVA
        public decimal PrezzoConIva()
        {
            return Prezzo * (1 + (Iva / 100));
        }
    }
}
