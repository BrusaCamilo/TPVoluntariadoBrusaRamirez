
using System;

public class Coordinador : Miembro
{
    private string areaAsignada;
    private int personasACargo;

    public string AreaAsignada
    {
        get { return this.areaAsignada; }
        set { this.areaAsignada = value; }
    }

    public int PersonasACargo
    {
        get { return this.personasACargo; }
        set { this.personasACargo = value; }
    }

    public Coordinador(int id, string nombre, string apellido, string areaAsignada, int personasACargo) : base(id, nombre, apellido)
    {
        this.areaAsignada = areaAsignada;
        this.personasACargo = personasACargo;
    }

    public override void MostrarDatos()
    {
        Console.WriteLine("=== COORDINADOR ===");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Área asignada: {AreaAsignada}");
        Console.WriteLine($"Personas a cargo: {PersonasACargo}");
    }
}