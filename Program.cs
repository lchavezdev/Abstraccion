public class Program
{
    public static void Main()
    {
        Gerente gerente = new Gerente();
        gerente.Nombre = "Luis";
        gerente.Id = 1;
        gerente.SalarioBase = 10000;
        gerente.BonoAnual = 1000;

        Desarrollador desarrollador = new Desarrollador();
        desarrollador.Nombre = "Fernando";
        desarrollador.Id = 2;
        desarrollador.SalarioBase = 5000;
        desarrollador.LenguajePrincipal = "C#";

        Contador contador = new Contador();
        contador.Nombre = "Chavez";
        contador.Id = 3;
        contador.SalarioBase = 2000;
        contador.HorasExtras = 5;
        contador.PagoPorHoraExtra = 10;

        Console.WriteLine("Información del gerente:");
        gerente.MostrarInformacion();
        Console.WriteLine($"Salario anual: {gerente.CalcularSalarioAnual()}");


        Console.WriteLine("Información del desarrollador:");
        desarrollador.MostrarInformacion();
        Console.WriteLine($"Salario anual: {desarrollador.CalcularSalarioAnual()}");

        Console.WriteLine("Información del contador:");
        contador.MostrarInformacion();
        Console.WriteLine($"Salario anual: {contador.CalcularSalarioAnual()}");

    }
}