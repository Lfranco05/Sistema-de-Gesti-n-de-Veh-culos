Public Class Camion
public class Camion : Vehiculo
{
    private double _capacidadDeCarga;

    public double CapacidadDeCarga { get => _capacidadDeCarga; set => _capacidadDeCarga = value; }

    public Camion(string marca, string modelo, int año, double kilometraje, double capacidadDeCarga)
        : base(marca, modelo, año, kilometraje)
    {
        _capacidadDeCarga = capacidadDeCarga;
    }

    public override void Encender()
    {
        Console.WriteLine("Encendiendo camión...");
    }

    public override void Apagar()
    {
        Console.WriteLine("Apagando camión...");
    }

    public override void Conducir(double km)
    {
        Console.WriteLine($"Conduciendo camión {km} km...");
        Kilometraje += km;
    }
}
End Class
