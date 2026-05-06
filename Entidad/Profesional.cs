using System.Text.Json.Serialization;

namespace ActividadClaseU5AulaII;

public class Profesional : Jugador, IEntrevistable
{
    private double Sueldo { get; set; }
    private string Patrocinador { get; set; }

    public Profesional(string nombre, string alias, int nivel, double sueldo, string patrocinador) 
        : base(nombre, alias, nivel)
    {
        Sueldo = sueldo;
        Patrocinador = patrocinador;
    }

    public void RealizarDeclaraciones()
    {
        throw new ArgumentException();
    }
}