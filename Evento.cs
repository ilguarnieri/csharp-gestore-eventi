using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienza;
        public int PostiPrenotati { get; private set; }

        public string Titolo
        {
            get => this.titolo;
            set
            {
                try
                {
                    if (this.titolo != "")
                    {
                        this.titolo = value;
                    }
                    else
                    {
                        throw new Exception("Il titolo del evento è vuoto!");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public DateTime Data
        {
            get => this.data;
            set
            {
                try
                {
                    if(DateTime.Compare(value, DateTime.Now) >= 0 ){
                        this.data = value;
                    }else
                    {
                        throw new Exception("La data è passata!");
                    }
                }
                catch( Exception e )
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        public int Capienza
        {
            get => this.capienza;
            set
            {
                try
                {
                    if(value > 0)
                    {
                        this.capienza = value;
                    }
                    else
                    {
                        throw new Exception("La capienza del evento deve essere un numero positivo!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        public Evento(string titolo, DateTime data, int capienza)
        {
            this.Titolo = titolo;
            this.Data = data;
            this.Capienza = capienza;
            this.PostiPrenotati = 0;
        }



        public void PrenotaPosti(int posti)
        {
            try
            {
                if(DateTime.Compare(this.Data, DateTime.Now) >= 0)
                {
                    if(this.Capienza - this.PostiPrenotati >= posti)
                    {
                        this.PostiPrenotati += posti;
                    }
                    else
                    {
                        throw new Exception("Non ci sono posti disponibili!");
                    }
                }
                else
                {
                    throw new Exception("L'evento è concluso!");
                }
            }
            catch ( Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }


        public void DisdiciPosti(int posti)
        {
            try
            {
                if( DateTime.Compare(this.Data, DateTime.Now) >= 0)
                {
                    if (this.PostiPrenotati >= posti)
                    {
                        //prenota
                        this.PostiPrenotati -= posti;
                    }
                    else
                    {
                        throw new Exception("Non ci sono posti da disdire sufficienti!");
                    }
                }
                else
                {
                    throw new Exception("L'evento è concluso!");
                }

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        public override string ToString()
        {
            return this.Data.ToString("dd/MM/yyyy") + " - " + this.Titolo;
        }




    }
}
