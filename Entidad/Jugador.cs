namespace ActividadClaseU5AulaII;

public class Jugador
{
    private string Nombre { get; }
    private string Alias { get; }
    private int Nivel { get; }

    public Jugador(string nombre, string alias, int nivel)
    {
        Nombre = nombre;
        Alias = alias;
        Nivel = nivel;
    }
}