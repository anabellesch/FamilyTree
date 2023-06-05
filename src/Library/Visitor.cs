
using System;
using System.Collections.Generic;
using Library;


public abstract class Visitor
{
    public abstract void Visit(Persona persona);
}

public class SumaEdadesVisitor : Visitor
{
    private int sumaEdades;

    public SumaEdadesVisitor()
    {
        sumaEdades = 0;
    }

    public int GetSumaEdades()
    {
        return sumaEdades;
    }

    public override void Visit(Persona persona)
    {
        sumaEdades += persona.Edad;
    }

}