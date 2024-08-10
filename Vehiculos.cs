Public Class Vehiculos
{
    private string _marca;
    private string _modelo;
    private int _año;
    private double _kilometraje;

    public string Marca { get => _marca; set => _marca = value; }
    public string Modelo { get => _modelo; set => _modelo = value; }
    public int Año { get => _año; set => _año = value; }
    public double Kilometraje { get => _kilometraje; set => _kilometraje = value; }

    public abstract void Encender();
    public abstract void Apagar();
    public abstract void Conducir(double km);

    public Vehiculo(string marca, string modelo, int año, double kilometraje)
    {
        _marca = marca;
        _modelo = modelo;
        _año = año;
        _kilometraje = kilometraje;
    }
}
End Class
