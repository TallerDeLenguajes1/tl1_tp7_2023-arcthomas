namespace espacioEmpleado;

public enum Cargos
{
    Auxiliar = 0,
    Administrativo = 1,
    Ingeniero = 2,
    Especialista = 3,
    Investigador = 4
}
public class Empleado
{

    private Cargos Cargo;
    private string? Nombre;
    private string? Apellido;
    private DateTime FNac;
    private char Civil;
    private char Genero;
    private DateTime FIngreso;

    public Empleado(Cargos CargoIn, string NombreIn, string ApellidoIn, DateTime FNacIn, char CivilIn, char GeneroIn, DateTime FIngresoIn)
    {
        Cargo = CargoIn;
        Nombre = NombreIn;
        Apellido = ApellidoIn;
        FNac = FNacIn;
        Civil = CivilIn;
        Genero = GeneroIn;
        FIngreso = FIngresoIn;
    }

    public void Antiguedad()
    {
        var horas = (DateTime.Now - FIngreso).ToString(@"dd\d\ hh\h\ mm\m\ ");
        Console.WriteLine("El empleado tiene una antiguedad de: " + horas);
    }
    public void Edad()
    {
        var edad = (DateTime.Now - FNac).Days;
        edad /= 365;
        Console.WriteLine("El empleado tiene: " + edad + " años");
    }
    public void CalcTmpJubilacion()
    {
        var edad = (DateTime.Now - FNac).Days;
        edad /= 365;
        if (Genero == 'M')
        {
            Console.WriteLine("Al empleado le fantan "+ (65 - edad) + " años para poder jubilarse");
        }
        else
        {
            Console.WriteLine("A la empleada le fantan "+ (60 - edad) + " años para poder jubilarse");
        }
    }
}