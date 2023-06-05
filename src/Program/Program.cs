using System;
using Library;
using System.Collections.Generic;

namespace Program
{
   
    class Program
    {
        static void Main(string[] args)
        {

            Node n1= new Node(new Persona("nombre", 80));
            Node n2 = new Node(new Persona("nombre2", 45));
            Node n3 = new Node(new Persona("nombre3", 40));
            Node n4 = new Node(new Persona("nombre4", 10));
            Node n5 = new Node(new Persona("nombre5",5));
            Node n6 = new Node(new Persona("nombre6",10));
            Node n7 = new Node(new Persona("nombre7",15));
            Node n8 = new Node(new Persona("nombre8",67));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
        }
    }
}
