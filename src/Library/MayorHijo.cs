using System;
using Library;

public class MayorHijoVisitor : Visitor
{
    private int mayorEdad;
    private string mayorHijo;

    public MayorHijoVisitor()
    {
        mayorEdad = 0;
        mayorHijo = "";
    }

    public string GetMayorHijo()
    {
        return mayorHijo;
    }

    public override void Visit(Persona persona)
    {
        if (persona.Edad > mayorEdad)
        {
            mayorEdad = persona.Edad;
            mayorHijo = persona.Nombre;
        }
    }

}