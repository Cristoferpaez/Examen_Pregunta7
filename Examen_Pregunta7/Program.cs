using System;

abstract class Pais
{
    public abstract string ColorBandera();
    public abstract string Tamaño();
    public abstract string IdiomaOficial();
}


class Ecuador : Pais
{
    public override string ColorBandera()
    {
        return "Amarillo, azul y rojo";
    }

    public override string Tamaño()
    {
        return "283,561 km²";
    }

    public override string IdiomaOficial()
    {
        return "Español";
    }
}

class Brasil : Pais
{
    public override string ColorBandera()
    {
        return "Verde y amarillo";
    }

    public override string Tamaño()
    {
        return "8,515,767 km²";
    }

    public override string IdiomaOficial()
    {
        return "Portugués";
    }
}

class Andorra : Pais
{
    public override string ColorBandera()
    {
        return "Azul, amarillo y rojo";
    }

    public override string Tamaño()
    {
        return "468 km²";
    }

    public override string IdiomaOficial()
    {
        return "Catalán";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ecuador ecuador = new Ecuador();
        Brasil brasil = new Brasil();
        Andorra andorra = new Andorra();

        Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera());
        Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño());
        Console.WriteLine("Idioma oficial de Brasil: " + brasil.IdiomaOficial());
    }
}