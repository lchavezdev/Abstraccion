public class Contador : Empleado
{
    public int HorasExtras { get; set; }
    public double PagoPorHoraExtra { get; set; }

    public override double CalcularSalarioAnual()
    {
        return (SalarioBase*12) + (HorasExtras*PagoPorHoraExtra);
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Salario: {SalarioBase}");
        Console.WriteLine($"Horas extras: {HorasExtras}");
        Console.WriteLine($"Pago por hora extra: {PagoPorHoraExtra}");
    }
}