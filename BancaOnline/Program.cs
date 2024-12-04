namespace BancaOnline;

class Program
{
    static void Main(string[] args)
    {
        var banquer = new Banquer();
        
        banquer.CrearClient("Frederic");
        
        
        Console.WriteLine(banquer .PosarDiners("Frederic", 100));
        Console.WriteLine(banquer .TreureDiners("Frederic",200));
        Console.WriteLine(banquer .TreureDiners("Frederic",10));
        Console.WriteLine(banquer .TreureDiners("Manel",20));
        
        banquer.CrearClient("Manel");
        Console.WriteLine(banquer .PosarDiners("Manel", 50));

    }
}