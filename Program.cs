
using GestoreEventi;

Console.Write("Inserisci il nome dell'evento: ");
string titolo = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
DateTime data = Convert.ToDateTime(Console.ReadLine());

Console.Write("Inserisci il numero di posti totali: ");
int capienza = Int32.Parse(Console.ReadLine());


Evento evento = new Evento(titolo, data, capienza);

Console.Write("Desideri prenotare dei posti (s/n)?");
string choicePrenotazione = Console.ReadLine();

while(choicePrenotazione != "s" && choicePrenotazione != "n")
{
    Console.WriteLine("Inserisci un valore corretto s/n");
    choicePrenotazione = Console.ReadLine();
}

if (choicePrenotazione == "s")
{
    Console.Write("Quanti posti desideri prenotare? ");
    int numberPosti = Int32.Parse(Console.ReadLine());
    evento.PrenotaPosti(numberPosti);
}

Console.WriteLine($"\nNumero posti prenotati = {evento.PostiPrenotati}");
Console.WriteLine($"Numero posti disponibili = {evento.Capienza - evento.PostiPrenotati}");


bool yesChoice = false;

do
{
    Console.WriteLine("\nVuoi disdire dei posti (s/n)?");
    string choiceDisdici = Console.ReadLine();

    while (choiceDisdici != "s" && choiceDisdici != "n")
    {
        Console.Write("Inserisci un valore corretto s/n");
        choiceDisdici = Console.ReadLine();
    }

    if (choiceDisdici == "s")
    {
        Console.Write("Indica il numero dei posti da disdire: ");
        int numberPosti = Int32.Parse(Console.ReadLine());
        evento.DisdiciPosti(numberPosti);

        yesChoice = true;

        Console.WriteLine($"\nNumero posti prenotati = {evento.PostiPrenotati}");
        Console.WriteLine($"Numero posti disponibili = {evento.Capienza - evento.PostiPrenotati}");
    }
    else
    {
        yesChoice = false;
        Console.WriteLine("Ok va bene!");
    }

}while(yesChoice);