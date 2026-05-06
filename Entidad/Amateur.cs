namespace ActividadClaseU5AulaII;

public class Amateur : Jugador
{
    private string CentroEstudio { get; set; }

    public Amateur(string nombre, string alias, int nivel, string centroEstudio) : base(nombre, alias, nivel)
    {
        CentroEstudio = centroEstudio;
    }
}