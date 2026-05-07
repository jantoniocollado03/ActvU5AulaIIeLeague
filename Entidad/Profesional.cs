using System.Text.Json.Serialization;

namespace ActividadClaseU5AulaII;

public class Profesional : Jugador, IEntrevistable
{
    public double Sueldo { get; set; }
    public string Patrocinador { get; set; }

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