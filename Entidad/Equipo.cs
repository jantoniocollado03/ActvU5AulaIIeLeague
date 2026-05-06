namespace ActividadClaseU5AulaII;

public class Equipo
{
    private string Nombre { get; set; }
    private DateTime FechaFund { get; set; }
    public List<Jugador> Jugadores { get; private set; }
    public PerfilEstad Estadisticas { get; private set; }

    public Equipo(string nombre, DateTime fechaFund)
    {
        Nombre = nombre;
        FechaFund = fechaFund;
        Estadisticas = new PerfilEstad();
        Jugadores = new List<Jugador>();
    }

    public void FicharJugador(Jugador nuevoJugador)
    {
        Jugadores.Add(nuevoJugador);
    }
}