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

    private Cargos _cargo;
    private string? _nombre;
    private string? _apellido;
    private DateTime _fNac;
    private char _civil;
    private char _genero;
    private DateTime _fIngreso;
    private double _sueldoBasico;
    private double _sueldoTotal;
    private double _edad;
    private double _antiguedad;
    private int _tmpAJubilarse;
    public Cargos Cargo
    {
        get { return _cargo; }
    }
    public string? Nombre
    {
        get { return _nombre; }
    }
    public string? Apellido
    {
        get { return _apellido; }
    }
    public DateTime FNac
    {
        get { return _fNac; }
    }
    public char EstadoCivil
    {
        get { return _civil; }
    }
    public char Genero
    {
        get { return _genero; }
    }
    public DateTime FIngreso
    {
        get { return _fIngreso; }
    }
    public double SueldoBasico
    {
        get { return _sueldoBasico; }
    }
    public double SueldoTotal
    {
        get { return _sueldoTotal; }
    }
    public double Edad
    {
        get { return _edad; }
    }
    public double Antiguedad
    {
        get { return _antiguedad; }
    }
    public int TmpAJubilarse
    {
        get { return _tmpAJubilarse; }
    }

    public Empleado(Cargos CargoIn, string nombreIn, string apellidoIn, DateTime fNacIn, char civilIn, char generoIn, DateTime fIngresoIn, double SueldoIn)
    {
        _cargo = CargoIn;
        _nombre = nombreIn;
        _apellido = apellidoIn;
        _fNac = fNacIn;
        _civil = civilIn;
        _genero = generoIn;
        _fIngreso = fIngresoIn;
        _sueldoBasico = SueldoIn;
        _edad = (DateTime.Now - _fNac).Days;
        _edad /= 365;
        _edad = Math.Round(_edad);
        _antiguedad = (DateTime.Now - _fIngreso).TotalDays;
        _antiguedad /= 365;
        _antiguedad = Math.Round(_antiguedad);
        if (_genero == 'M')
        {
            _tmpAJubilarse = 65 - (int)_edad;
        }
        else
        {
            _tmpAJubilarse = 60 - (int)_edad;
        }
    }

    public void mostrarAntiguedad()
    {
        if (_genero == 'M')
        {
            switch (_antiguedad)
            {
                case 0:
                    Console.WriteLine("El empleado tiene menos de un año de antigüedad");
                    break;
                case 1:
                    Console.WriteLine("El empleado tiene un año de antigüedad");
                    break;
                default:
                    Console.WriteLine("El empleado tiene " + _antiguedad + " años de antigüedad");
                    break;
            }
        }
        else
        {
            switch (_antiguedad)
            {
                case 0:
                    Console.WriteLine("La empleada tiene menos de un año de antigüedad");
                    break;
                case 1:
                    Console.WriteLine("La empleada tiene un año de antigüedad");
                    break;
                default:
                    Console.WriteLine("La empleada tiene " + _antiguedad + " años de antigüedad");
                    break;
            }
        }
    }
    public void mostrarEdad()
    {
        if (_genero == 'M')
        {
            Console.WriteLine("El empleado tiene: " + _edad + " años");
        }
        else
        {
            Console.WriteLine("La empleada tiene: " + _edad + " años");
        }
    }
    public void mostrarTmpJubilacion()
    {
        if (_genero == 'M')
        {
            Console.WriteLine("Al empleado le fantan " + (65 - _edad) + " años para poder jubilarse");
        }
        else
        {
            Console.WriteLine("A la empleada le fantan " + (60 - _edad) + " años para poder jubilarse");
        }
    }
    public void mostrarSueldo()
    {
        double adicional;
        if (_antiguedad < 19)
        {
            adicional = _sueldoBasico * (_antiguedad / 100);
        }
        else
        {
            adicional = _sueldoBasico * (25 / 100);
        }
        if ((int)_cargo == 2 || (int)_cargo == 3)
        {
            adicional += adicional * (50 / 100);
        }
        if (_civil == 'C')
        {
            adicional += 15000;
        }
        _sueldoTotal = _sueldoBasico + adicional;
        if (_genero == 'M')
        {
            Console.WriteLine("El sueldo total de el empleado es: " + Math.Round(_sueldoTotal, 2));
        }
        else
        {
            Console.WriteLine("El sueldo total de la empleada es: " + Math.Round(_sueldoTotal, 2));
        }
    }
    public double obtenerSueldoTotal()
    {
        return _sueldoTotal;
    }
    public void mostrarProxAJubilarse(Empleado empleado1, Empleado empleado2, Empleado empleado3)
    {
        int min;
        List<Empleado> lista = new List<Empleado>();
        lista.Add(empleado1);
        lista.Add(empleado2);
        lista.Add(empleado3);
        min = Math.Min(empleado1.TmpAJubilarse, Math.Min(empleado2.TmpAJubilarse, empleado3.TmpAJubilarse));
        for (int i = 0; i < 3; i++)
        {
            if (min == lista[i].TmpAJubilarse)
            {
                Console.WriteLine("-- Datos del empleado o empleada más próximo a jubilarse --");
                Console.WriteLine("\nNombre: " + lista[i].Nombre);
                Console.WriteLine("Apellido: " + lista[i].Apellido);
                Console.WriteLine("Cargo: " + lista[i].Cargo);
                Console.WriteLine("Edad: " + lista[i].Edad);
                Console.WriteLine("Estado civil: " + lista[i].EstadoCivil);
                Console.WriteLine("Genero: " + lista[i].Genero);
                Console.WriteLine("Fecha de ingreso: " + lista[i].FIngreso.ToString("dd/MM/yyyy"));
                Console.WriteLine("Sueldo básico: " + lista[i].SueldoBasico);
                Console.WriteLine("Sueldo total: " + lista[i].SueldoTotal);
            }
        }
    }
    public void mostrarMontoTotalSueldos(Empleado empleado1, Empleado empleado2, Empleado empleado3)
    {
        double total;
        total = empleado1.SueldoTotal + empleado2.SueldoTotal + empleado3.SueldoTotal;
        Console.WriteLine("El monto total en sueldos de los empleados es: " + total);
    }
}