namespace ActividadClaseU5AulaII;

public class Jugador
{
    public string Nombre { get; }
    public string Alias { get; }
    public int Nivel { get; }

    public Jugador(string nombre, string alias, int nivel)
    {
        Nombre = nombre;
        Alias = alias;
        Nivel = nivel;
    }
}