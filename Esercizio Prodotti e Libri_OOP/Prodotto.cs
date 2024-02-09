using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Prodotti_e_Libri_OOP
{
    // Creo la classe Prodotto(classe base). Definisco tutti gli attributi e i metodi 'public' perchè voglio rendere il codice accessibile per tutte le classi.
    internal class Prodotto
    {
        // Definisco gli attributi o proprietà della classe Prodotto.
        public string codice { get; set; } = string.Empty;
        public string nome { get; set; } = string.Empty;
        public double prezzo { get; set; } = 0;

        // Definisco il costruttore vuoto della classe Prodotto.
        public Prodotto()
        {
            this.codice = string.Empty;
            this.nome = string.Empty;
            this.prezzo = 0;
        }

        // Definisco il secondo costruttore, stavolta passandogli dei parametri(overload del metodo costruttore).
        public Prodotto(string pCodice, string pNome, double pPrezzo)
        {
            this.codice = pCodice;
            this.nome = pNome;
            this.prezzo= pPrezzo;
        }

        // Definisco un metodo per visualizzare le caratteristiche del prodotto. Lo definisco 'virtual', così consento al metodo di essere sottoposto a override nella classe derivata 'Libro'.
        public virtual void visualizzaCaratteristiche()
        {
            Console.WriteLine("Codice prodotto: {0}; Nome prodotto: {1}; Prezzo prodotto: {2} .", this.codice, this.nome, this.prezzo);
        }

        // Definisco un metodo per calcolare il prezzo scontato di un prodotto. Anche questo metodo lo definisco 'virtual', così consento al metodo di essere sottoposto a override nella classe derivata 'Libro'.
        public virtual void calcolaPrezzoScontato() // La funzione la definisco void perchè non restituisce nulla.
        {
            double sconto = 0, prezzoScontato = 0;
            Console.WriteLine("Che sconto vuoi applicare al prodotto?");
            sconto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bene al prodotto verrà applicato uno sconto del " + sconto * 100 + " %.");
            prezzoScontato = this.prezzo * (1 - sconto);
            Console.WriteLine("Il prodotto scontato costa " + prezzoScontato + " euro.");
        }
    }
}
