using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Conferenza : Evento
    {
        public string Relatore { get; private set; }
        public int Prezzo { get; private set; }

        public Conferenza(string titolo, string relatore, DateTime data, int prezzo, int capienza) : base(titolo, data, capienza)
        {
            Relatore = relatore;
            Prezzo = prezzo;
        }


        public string DataFormat()
        {
            return this.Data.ToString("dd/MM/yyyy");
        }


        public string PrezzoFormat()
        {

            return this.Prezzo.ToString("0.00");
        }


        public override string ToString()
        {
            return this.DataFormat() + " - " + this.Titolo + " - " + this.Relatore + " - " + this.PrezzoFormat() + " euro";
        }




        public static Conferenza CreaConferenza()
        {

            Console.Write("Inserisci il nome della conferenza: ");
            string titolo = Console.ReadLine();

            Console.Write("Inserisci la data della conferenza (gg/mm/yyyy): ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Inserisci il numero di posti per la conferenza: ");
            int capienza = Int32.Parse(Console.ReadLine());

            Console.Write("Inserisci il relatore della conferenza: ");
            string relatore = Console.ReadLine();

            Console.Write("Inserisci il prezzo del biglietto della conferenza: ");
            int prezzo = Int32.Parse(Console.ReadLine());

            Conferenza conferenza = new Conferenza(titolo, relatore, data, prezzo, capienza);

            return conferenza;
        }
    }
}
