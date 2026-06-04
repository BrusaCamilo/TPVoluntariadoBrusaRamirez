using System;
using System.Runtime.CompilerServices;

public abstract class Miembro{


    private int id;
    private string nombre;
    private string apellido;



public int Id {get{return this.id;}set{this.id=value;}}
public string Nombre {get{return this.nombre;}set{this.nombre=value;}}
public string Apellido {get{return this.apellido;}set{this.apellido=value;}}



public Miembro(int id, string nombre, string apellido)
{
this.id = id;       
this.nombre = nombre;
this.apellido = apellido;

}

    public abstract void MostrarDatos();

}