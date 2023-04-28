using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        // Attributi
        public string titolo;
        public string data;
        public int maxCapienza;
        public int postiPrenotati;



        // Costruttore
        public Evento(string titolo, string data, int maxCapienza, int postiPrenotati = 0)
        {

            this.titolo = titolo;
            this.data = data;
            this.maxCapienza = maxCapienza;
            this.postiPrenotati = postiPrenotati;
        }


        // Getters
        public string GetTitolo()
        {
            return this.titolo;
        }

        public string GetData()
        {
            DateTime data = DateTime.Parse(this.data);
            return this.data;
        }

        public int GetMaxCapienza()
        {
            return this.maxCapienza;
        }

        public int GetPostiPrenotati()
        {
            return this.postiPrenotati;
        }

        // Setters
        public void SetTitolo()
        {
            if (this.titolo == "")
            {
                string exceptionMessage = "Devi inserire un titolo!";
                throw new ArgumentException(exceptionMessage);
            }
        }

        public void SetMaxCapienza()
        {
            if (maxCapienza < 0)
            {
                string exceptionMessage = "Non puoi inserire un numero negativo!";
                throw new ArgumentException(exceptionMessage);
            }
        }

        // Methods
        public void PrenotaPosti(int maxCapienza)
        {
            if (postiPrenotati > maxCapienza)
            {
                string exceptionMessage = "Hai superato i posti disponibili!";
                throw new ArgumentException(exceptionMessage);
            }

        }

        public int DisdiciPosti(int postiprenotati)
        {
            postiPrenotati -= postiPrenotati;
            return postiPrenotati;
        }

        public override string ToString()
        {
            string eventInfo =
            $"Titolo dell'evento: {this.titolo} \n" +
            $"Data evento: {this.data} \n" +
            $"Totale posti disponibili: {this.maxCapienza} \n" +
            $"Posti prenotati: {this.postiPrenotati} \n";

            return eventInfo;
        }
    }
}
