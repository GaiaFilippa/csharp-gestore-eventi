/* Contesto e problema da risolvere:
Immaginate di lavorare in una software house, che ha diversi clienti. Vi è stato commissionato
da parte della vostra azienda la creazione di un gestionale eventi per eventi come concerti,
conferenze, spettacoli,... per un suo cliente. Il cliente necessita di un semplice programma
senza interfaccia grafica (ossia che venga eseguito in console o terminale) che si occupa di:
- Memorizzare e tenere traccia di tutti gli eventi in futuro che ha programmato
- Poter gestire le prenotazioni e le disdette delle sue conferenze e tenere traccia
quindi dei posti prenotati e di quelli disponibili per un dato evento
- Poter gestire un intero programma di Eventi (ossia tenere traccia di tutti gli eventi
che afferiscono ad serie di Conferenze)
 */



using GestoreEventi;

/*
Evento nuovoEvento = new Evento("Concerto", "11/12/2002", 200, 3);
Console.WriteLine(nuovoEvento.ToString());
*/

try
{
    Console.WriteLine("Inserisci il nome dell'evento: ");
    string titoloUtente = Console.ReadLine();
    Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyyy): ");
    string dataUtente = Console.ReadLine();
    Console.WriteLine("Inserisci il numero di posti totali: ");
    string maxCapienzaUtente = Console.ReadLine();
    Console.WriteLine("Quanti posti desideri prenotare? ");
    string postiPrenotatiUtente = Console.ReadLine();

    Evento nuovoEvento = new Evento(titoloUtente, dataUtente, 200, 30);
    Console.WriteLine(nuovoEvento.ToString());
} catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }