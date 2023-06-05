using System;
using Library;

public class NombreMasLargoVisitor : Visitor
{
    private string nombreMasLargo;

    public NombreMasLargoVisitor()
    {
        nombreMasLargo = "";
    }

    public string GetNombreMasLargo()
    {
        return nombreMasLargo;
    }

    public override void Visit(Persona persona)
    {
        if (persona.Nombre.Length > nombreMasLargo.Length)
        {
            nombreMasLargo = persona.Nombre;
        }
    }


}