using System;
public interface ICastillo
{
    void MetodoConstruirCastillo();
}

public interface IMuralla
{
    void MetodoConstruirMuralla();
}

public interface IFoso
{
    void MetodoConstruirFoso();
}

public class Castillo : ICastillo
{
    public void MetodoConstruirCastillo()
    {
        Console.WriteLine("Castillo Construido");
    }
}

public class Muralla : IMuralla
{
    public void MetodoConstruirMuralla()
    {
        Console.WriteLine("Muralla Construida");
    }
}

public class Foso: IFoso
{
    public void MetodoConstruirFoso()
    {
        Console.WriteLine("Foso Construido");
    }
}


public interface IFabricaAbstracta
{
    ICastillo crearCastillo();
    IMuralla crearMuralla();
    IFoso crearFoso();

}

public class FabricaConcreta : IFabricaAbstracta
{
    public ICastillo crearCastillo()
    {
        return new Castillo();
    }

    public IMuralla crearMuralla()
    {
        return new Muralla();
    }

    public IFoso crearFoso()
    {
        return new Foso();
    }
}


public class Cliente
{
    public readonly ICastillo   _castillo;
    public readonly IMuralla    _muralla;
    public readonly IFoso       _foso;

    public  Cliente (IFabricaAbstracta fabrica)
    {
        _castillo=fabrica.crearCastillo();
        _muralla = fabrica.crearMuralla();
        _foso=fabrica.crearFoso();
    }

    public void ejecutar()
    {
        _castillo.MetodoConstruirCastillo();
        _muralla.MetodoConstruirMuralla();
        _foso.MetodoConstruirFoso();
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            IFabricaAbstracta fabricamedieval = new FabricaConcreta();
            Cliente felipeV =new Cliente(fabricamedieval);

            felipeV.ejecutar();
            

        }
    }





}



