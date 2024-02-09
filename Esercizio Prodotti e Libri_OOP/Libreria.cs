/* Esercizio: Crea una classe base chiamata 'Prodotto' con attributi come 'codice', 'nome', 'prezzo' e metodi per calcolare il prezzo scontato e per stampare le informazioni del prodotto. 
 Poi definisci una classe derivata chiamata 'Libro' che erediti dalla classe 'Prodotto' e aggiunga attributi come 'autore', 'genere' e metodi per calcolare il prezzo scontato specifico per i libri e per stampare le informazioni del libro.*/
namespace Esercizio_Prodotti_e_Libri_OOP
{
    internal class Libreria
    {
        static void Main(string[] args)
        {
            // Creo un oggettp 'Prodotto', chiamato 'prodotto' e utilizzo il costruttore con i parametri per inizializzare l'oggetto. Per creare l'oggetto utilizzo la parola chiave 'new'.
            Prodotto prodotto = new Prodotto("PROD01", "Libro", 12.50);
            prodotto.visualizzaCaratteristiche(); // Attraverso questa sintassi chiamo ed eseguo il metodo 'visualizzaCaratteristiche' per viaualizzare le caratteristiche di un prodotto.
            prodotto.calcolaPrezzoScontato(); // Attraverso questa sintassi chiamo ed eseguo il metodo 'calcolaPrezzoScontato' per calcolare lo sconto di un prodotto.

            // Creo un oggettp 'Libro', chiamato 'libro' e utilizzo il costruttore con i parametri per inizializzare l'oggetto. Per creare l'oggetto utilizzo la parola chiave 'new'.
            Libro libro = new Libro("LIBR01", "Zanna Bianca", 13.75, "Jack London", "Avventura");
            libro.visualizzaCaratteristiche(); // Attraverso questa sintassi chiamo ed eseguo il metodo 'visualizzaCaratteristiche' per viaualizzare le caratteristiche di un libro.
            libro.calcolaPrezzoScontato(); // Attraverso questa sintassi chiamo ed eseguo il metodo 'calcolaPrezzoScontato' per calcolare lo sconto di un libro.

            Console.WriteLine("PROGRAMMA TERMINATO");
        }
    }
}

// Esercizio terminato! Ora puoi eseguire il programma.
