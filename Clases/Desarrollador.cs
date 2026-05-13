public class Desarrollador : Empleado
{
    public string? LenguajePrincipal { get; set; }

    public override double CalcularSalarioAnual()
    {
        return SalarioBase*12;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Salario: {SalarioBase}");
        Console.WriteLine($"Lenguaje: {LenguajePrincipal}");
    }
}