static public class Escape
{
    private static string[] incongnitasSalas;
    private static int estadoJuego = 1;


    private static void InicializarJuego()
    {
        string [] incognitas = {"HRYRT", "7", "ROJA", "GGGEYDRTOFLMGCRM", "ROOESEOENUAEULAIAINE"};
        incongnitasSalas = incognitas;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita)
    {
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