Public Class Motocicleta
public class Motocicleta : Vehiculo
{
    private string _tipoDeMoto;

    public string TipoDeMoto { get => _tipoDeMoto; set => _tipoDeMoto = value; }

    public Motocicleta(string marca, string modelo, int año, double kilometraje, string tipoDeMoto)
        : base(marca, modelo, año, kilometraje)
    {
        _tipoDeMoto = tipoDeMoto;
    }

    public override void Encender()
    {
        Console.WriteLine("Encendiendo motocicleta...");
    }

    public override void Apagar()
    {
        Console.WriteLine("Apagando motocicleta...");
    }

    public override void Conducir(double km)
    {
        Console.WriteLine($"Conduciendo motocicleta {km} km...");
        Kilometraje += km;
    }
}

End Class
