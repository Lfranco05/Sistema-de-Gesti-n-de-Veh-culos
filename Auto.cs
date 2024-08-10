Public Class Auto
public class Auto : Vehiculo
{
    private int _numeroDePuertas;
    public int NumeroDePuertas { get => _numeroDePuertas; set => _numeroDePuertas = value; }

    public Auto(string marca, string modelo, int año, double kilometraje, int numeroDePuertas)
        : base(marca, modelo, año, kilometraje)
    {
        _numeroDePuertas = numeroDePuertas;
    }

    public override void Encender()
    {
        Console.WriteLine("Encendiendo auto...");
    }

    public override void Apagar()
    {
        Console.WriteLine("Apagando auto...");
    }

    public override void Conducir(double km)
    {
        Console.WriteLine($"Conduciendo auto {km} km...");
        Kilometraje += km;
    }
}
End Class
