// See https://aka.ms/new-console-template for more information
public class Asciugatrice : Macchinario
{
    public string nome = "";
    public bool inFunzione = false;
    public int tempoRimanente = 0;

    public void asciugaturaRapida()
    {
        this.tempoRimanente = 30;
    }
    public void asciugaturaIntensa()
    {
        this.tempoRimanente = 60;
    }
}