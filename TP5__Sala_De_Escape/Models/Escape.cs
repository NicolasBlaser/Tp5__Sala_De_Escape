static public class Escape
{
    private static string[] incongnitasSalas;
    private static int estadoJuego = 1;


    private static void InicializarJuego()
    {
        string [] incognitas = {"HRTYR", "7", "ROSA", "GGNAILLLOAECPDROE", "ROOESEOENUAEULAIAINE"};
        incongnitasSalas = incognitas;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita)
    {
        if(estadoJuego == 1)
        {
            InicializarJuego();
        }
        
        bool a = true;
        if(GetEstadoJuego() == Sala)
        {
            if(Incognita.ToUpper() == incongnitasSalas[Sala-1])
            {
                estadoJuego++;
            }
            else
            {
                a = false;
            }
        }
        else
        {
            a = false;
        }

        return a;
    }
}