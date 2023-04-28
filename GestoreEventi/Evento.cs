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
        public DateTime data;
        public int maxCapienza;
        public int postiPrenotati;


        // Costruttore
        public Evento(string titolo, string data, int maxCapienza, int postiPrenotati = 0)
        {

            this.titolo = titolo;
            this.data = DateTime.Parse(data);
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
            
            return this.data.ToString("dd/MM/yyyy");
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

        public void SetData()
        {
            if (this.data < DateTime.Now)
            {
                string exceptionMessage = "La data inserita è già passata!";
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
            } else if (this.data < DateTime.Now)
            {
                string exceptionMessage = "La data inserita è già passata!";
                throw new ArgumentException(exceptionMessage);
            }
        }

        public void CancellaPrenotazione(int postiCancellatiUtente)
        {
            if (postiPrenotati - postiCancellatiUtente < postiPrenotati && this.data > DateTime.Now)
            {
                postiPrenotati -= postiCancellatiUtente;
            }
            else
            {
                throw new ArgumentException("Impossibile cancellare la prenotazione!");
            }
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
