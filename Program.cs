
using GestoreEventi;

//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  MILESTONE 2 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


//Console.WriteLine("\n* Creazione nuovo evento *\n");

//Evento evento = Evento.CreaEvento();

//Console.Write("\nDesideri prenotare dei posti (s/n)? ");
//string choicePrenotazione = Console.ReadLine();

//while(choicePrenotazione != "s" && choicePrenotazione != "n")
//{
//    Console.Write("Inserisci un valore corretto s/n ");
//    choicePrenotazione = Console.ReadLine();
//}

//if (choicePrenotazione == "s")
//{
//    Console.Write("Quanti posti desideri prenotare? ");
//    int numberPosti = Int32.Parse(Console.ReadLine());
//    evento.PrenotaPosti(numberPosti);
//}

//Console.WriteLine($"\nNumero posti prenotati = {evento.PostiPrenotati}");
//Console.WriteLine($"Numero posti disponibili = {evento.Capienza - evento.PostiPrenotati}");


//bool yesChoice = false;

//do
//{
//    Console.Write("\nVuoi disdire dei posti (s/n)? ");
//    string choiceDisdici = Console.ReadLine();

//    while (choiceDisdici != "s" && choiceDisdici != "n")
//    {
//        Console.Write("Inserisci un valore corretto s/n");
//        choiceDisdici = Console.ReadLine();
//    }

//    if (choiceDisdici == "s")
//    {
//        Console.Write("Indica il numero dei posti da disdire: ");
//        int numberPosti = Int32.Parse(Console.ReadLine());
//        evento.DisdiciPosti(numberPosti);

//        yesChoice = true;

//        Console.WriteLine($"\nNumero posti prenotati = {evento.PostiPrenotati}");
//        Console.WriteLine($"Numero posti disponibili = {evento.Capienza - evento.PostiPrenotati}");
//    }
//    else
//    {
//        yesChoice = false;
//        Console.WriteLine("Ok va bene!");
//    }

//}while(yesChoice);




//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  MILESTONE 4 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


Console.WriteLine("\n* Creazione nuovo programma eventi *\n"); 

Console.Write("Inserisci il nome del tuo programma Eventi: ");
string titoloEvento = Console.ReadLine();

Console.Write("Indica il numero di eventi da inserire: ");
int numEventi = Int32.Parse(Console.ReadLine());

ProgrammaEventi programma = new ProgrammaEventi(titoloEvento);

int countEvento = 1;

do
{
    Console.WriteLine($"\n\n* * * {countEvento}º Evento * * *");

    Evento nuovoEvento;

    bool errorInput = true;

    do
    {
        try
        {
            nuovoEvento = Evento.CreaEvento();
            errorInput = false;
        }
        catch (Exception e)
        {
            Console.WriteLine("\n" + e.Message + "\n");
            errorInput = true;
        }
        finally
        {
            nuovoEvento = null;
        }

    } while (errorInput);


    programma.AggiungiEvento(nuovoEvento);

    countEvento++;

} while(countEvento <= numEventi);


Console.WriteLine($"\n\nIl numero di eventi nel programma è {programma.TotaleEventi()}");
Console.WriteLine("Ecco il tuo programma di eventi:");
Console.WriteLine(programma.DettaglioProgramma());

Console.Write("\nInserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");
DateTime dateInput = Convert.ToDateTime(Console.ReadLine());

List<Evento> eventiData = new List<Evento>();
eventiData = programma.ListaEventiData(dateInput);
if(eventiData.Count > 0)
{
    Console.WriteLine(ProgrammaEventi.StampaEventi(eventiData));
}
else
{
    Console.WriteLine("Non ci sono eventi in programma.");
}

programma.CancellaEventi();