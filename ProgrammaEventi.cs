using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        private string titolo;
        public string Titolo { get; set; }

        public List<Evento> eventi { get; set; }

        public ProgrammaEventi (string titolo)
        {
            this.Titolo = titolo;
            this.eventi = new List<Evento>();
        }


        public void AggiungiEvento(Evento evento)
        {
            this.eventi.Add(evento);
        }

        public List<Evento> ListaEventiData(DateTime data)
        {
            List<Evento> listaFiltrata = new List<Evento>();

            foreach(Evento evento in eventi)
            {
                if(DateTime.Compare(evento.Data, data) == 0)
                {
                    listaFiltrata.Add(evento);
                }
            }

            return listaFiltrata;
        }



        public static string StampaEventi(List<Evento> eventi)
        {
            string result = "";

            foreach(Evento evento in eventi)
            {
                result = result + $"\t{evento.ToString()}\n";
            }

            return result;
        }



        public int TotaleEventi()
        {
            return this.eventi.Count;
        }



        public void CancellaEventi()
        {
            this.eventi.Clear();
        }


        public string DettaglioProgramma()
        {
            return $"{this.Titolo}:\n" + ProgrammaEventi.StampaEventi(this.eventi);
        }


    }
}
