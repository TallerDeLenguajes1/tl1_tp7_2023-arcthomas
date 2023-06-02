namespace espacioCalculadora;

public class Calculadora
{
    private double dato;  

    public Calculadora()
    {
        dato = 0;
    }

    public double Resultado
    {
        get{
            return dato;
        }
    }

    public void Sumar(double x)
    {
        dato += x;
    }

    public void Restar(double x)
    {
        dato -= x;
    }

    public void Muliplicar(double x)
    {
        dato *= x;
    }

    public void Dividir(double termino)
    {
        dato /= termino;
    }
    public void Limpiar()
    {
        dato = 0;
    }
}