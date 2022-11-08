// See https://aka.ms/new-console-template for more information
public class Lavatrice : Macchinario
{
    public string nome = "";
    public bool inFuzione = false;
    public int quantitàDetersivo = 1000;
    public int quantitàAmmorbidente = 500;
    public int tempoRimanente = 0;
    public string programmaInCorso = "nessuno";

    
    public void LavaggioRinfrescante()
    {
        if (!inFuzione)
        {
            this.quantitàDetersivo -= 20;
            this.quantitàAmmorbidente -= 5;
            this.tempoRimanente = 20;
            this.programmaInCorso = "Rinfrescante";
        }
        else
        {
            Console.WriteLine("Mi spiace ma il macchinario è ancora in funzione. Aspettare che termini il programma");
        }
    }
    public void LavaggioRinnovante()
    {
        if (!inFuzione)
        {
            this.quantitàDetersivo -= 40;
            this.quantitàAmmorbidente -= 10;
            this.tempoRimanente = 40;
            this.programmaInCorso = "Rinnovante";
        }
        else
        {
            Console.WriteLine("Mi spiace ma il macchinario è ancora in funzione. Aspettare che termini il programma");
        }
    }
    public void LavaggioSgrassante()
    {
        if (!inFuzione)
        {
            this.quantitàDetersivo -= 60;
            this.quantitàAmmorbidente -= 15;
            this.tempoRimanente = 60;
            this.programmaInCorso = "Sgrassante";
        }
        else
        {
            Console.WriteLine("Mi spiace ma il macchinario è ancora in funzione. Aspettare che termini il programma");
        }
    }
    public void dettagliMacchina()
    {
        Console.Write("Nome: " + this.nome + " Quantità detersivo: " + this.quantitàDetersivo + "mL" + " Quantità ammorbidente: " + this.quantitàAmmorbidente + "mL");
        if (this.inFunzione)
        {
            Console.Write("Stato: in funzione" + " Tipologia di programma: " + this.programmaInCorso + " Tempo rimanente: " + this.tempoRimanente);
        }
        else
        {
            Console.Write("Macchinario non in funzione");
        }
    }
}