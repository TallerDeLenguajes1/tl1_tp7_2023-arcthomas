using espacioCalculadora;

Calculadora cal = new Calculadora();

float a = 0;
int aux;
do
{
    Console.WriteLine("Calculadora V1\n0 - Salir\n1 - Suma\n2 - Resta\n3 - Multiplicacion\n4 - Division\n5 - Limpiar valor\nIngrese una opcion: ");
    int.TryParse(Console.ReadLine(), out aux);
    if (aux != 0)
    {
        if (aux != 5)
        {
            Console.Write("Ingrese el valor de a: ");
            float.TryParse(Console.ReadLine(), out a);
        }

        switch (aux)
        {
            case 1:
                cal.Sumar(a);
                break;
            case 2:
                cal.Restar(a);
                break;
            case 3:
                cal.Muliplicar(a);
                break;
            case 4:
                cal.Dividir(a);
                break;
            case 5:
                cal.Limpiar();
                break;
            default:
                break;
        }
        Console.WriteLine("\nEl resultado es: " + cal.Resultado);
    }
} while (aux != 0);
Console.WriteLine("\nFin del programa");