namespace BancaOnline;

public class Banquer
{
    private Dictionary<string, Client> clients;
    

    public Banquer()
    {
        clients = new Dictionary<string , Client>();
    }

    public void CrearClient(string nomnouCliente)
    {
        clients.Add(nomnouCliente, new Client(nomnouCliente));
    }
    public string PosarDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            client.Saldo += quantitat;
            return $"{nomClient} ingressa {quantitat} euros, estan ingressats correctament";
        } 
        return $"Tu no ets client {nomClient}";
    }

    public string TreureDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            var comissio = quantitat / 100; 
            if (quantitat + comissio > client.Saldo)
            {
                return $"No tens {quantitat + comissio} diners";
            }
            client.Saldo -= quantitat + comissio;
            return $"{nomClient} Tingui {quantitat} euros et queden {client.Saldo} diners";
        }

        return $"Tu no ets client {nomClient}";
    }
    
    
}