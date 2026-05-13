public class Gerente : Empleado
{
    public double BonoAnual { get; set; }

    public override double CalcularSalarioAnual()
    {
        return (SalarioBase*12)+BonoAnual;
    }
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Salario: {SalarioBase}");
        Console.WriteLine($"Bono: {BonoAnual}");
    }
}
