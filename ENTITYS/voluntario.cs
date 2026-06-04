using System;
public class Voluntario : Miembro
{
    private int horasTrabajadas;

    public int HorasTrabajadas 
    { 
        get { return this.horasTrabajadas; } 
        set { this.horasTrabajadas = value; } 
    }

    public Voluntario(int id, string nombre, string apellido, int horasTrabajadas) 
        : base(id, nombre, apellido) 
    {
        this.horasTrabajadas = horasTrabajadas;
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"[VOLUNTARIO] Nombre: {Nombre} {Apellido} | Horas Trabajadas: {HorasTrabajadas} hs");
    }
}