namespace BancaOnline;

public class Client
{
    private string Nom { get; }
    public int Saldo { get; set; } = 0;

    public Client(string nomClient)
    {
        Nom = nomClient;
        Saldo = 0;
    }
    
}