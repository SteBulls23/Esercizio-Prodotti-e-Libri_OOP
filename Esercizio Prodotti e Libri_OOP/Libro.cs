using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Prodotti_e_Libri_OOP
{
    // Creo la classe Libro(classe derivata) che estende la classe Prodotto, in quanto un libro è anche un prodotto. Definisco tutti gli attributi e i metodi 'public' perchè voglio rendere il codice accessibile per tutte le classi.
    internal class Libro : Prodotto
    {
        // Definisco gli attributi o proprietà della classe libro.
        public string autore {  get; set; } = string.Empty;
        public string genere {  get; set; } = string.Empty;

        // Definisco il costruttore vuoto della classe libro.
        public Libro() 
        {
            this.autore = string.Empty;
            this.genere = string.Empty;
        }

        // Definisco il secondo costruttore, stavolta passandogli dei parametri(overload del metodo costruttore). 

        public Libro(string pCodice, string pNome, double pPrezzo, string pAutore, string pGenere) : base(pCodice, pNome, pPrezzo) /* La parola chiave 'base' viene usata per accedere ai membri della classe
                                                                                                                                     base, dall'interno della classe derivata, che può essere un metodo sulla classe di base 
                                                                                                                                    che è stato sostituito da un altro metodo, oppure per specificare quale costruttore di classe di base
                                                                                                                                    dve essere chiamato durante la creazione di istanze della classe derivata.*/
        {
            this.autore = pAutore;
            this.genere = pGenere;
        }

        // Definisco un metodo per visualizzare le caratteristiche del libro. In questo caso faccio l'override del metodo 'visualizzaCaratteristiche'.
        public override void visualizzaCaratteristiche() // La funzione la definisco void perchè non restituisce nulla.
        {
            Console.WriteLine("Codice libro: {0}; Nome libro: {1}; Prezzo libro: {2}; Autore libro: {3}; Genere libro: {4} .", this.codice, this.nome, this.prezzo, this.autore, this.genere);
        }

        // Definisco un metodo per calcolare il prezzo scontato di un libro. In questo caso faccio l'override del metodo 'calcolaPrezzoScontato'. L'override è l'operazione di riscrittura di un metodo ereditato.
        public override void calcolaPrezzoScontato() // La funzione la definisco void perchè non restituisce nulla.
        {
            double sconto = 0, prezzoScontato = 0;
            Console.WriteLine("Che sconto vuoi applicare al libro?");
            sconto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bene al libro verrà applicato uno sconto del " + sconto * 100 + " %.");
            prezzoScontato = this.prezzo * (1 - sconto);
            Console.WriteLine("Il libro scontato costa " + prezzoScontato + " euro.");
        }
    }
}

