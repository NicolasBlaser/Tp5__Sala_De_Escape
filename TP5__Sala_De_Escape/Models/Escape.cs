static public class Escape
{
    private static string[] incongnitasSalas;
    private static int estadoJuego = 0;


    private static void InicializarJuego()
    {
        string [] incognitas = {"HRYRT", "7", "ROJA", "GGGEYDRTOFLMGCRM", "ROOESEOENUAEULAIAINE"};
        incongnitasSalas = incognitas;
        estadoJuego = 1;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita)
    {
        if(estadoJuego == 0)
        {
            InicializarJuego();
        }
        
        bool a = true;
        if(GetEstadoJuego() == Sala)
        {
            if(Incognita == incongnitasSalas[Sala])
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