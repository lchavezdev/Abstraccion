using System.Security.Cryptography.X509Certificates;

public abstract class Empleado
{
    public string? Nombre { get; set; }
    public int Id { get; set; }
    public double SalarioBase { get; set; }

    public abstract double CalcularSalarioAnual();


    public abstract void MostrarInformacion();
}

