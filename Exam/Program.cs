using System;
public class MaterialBibliografico
{

    public string Titulo { get; set; }
    public string Autor { get; set; }

 
    public MaterialBibliografico(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }
   public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
    }
}

class Program
{
    static void Main()
    {
        MaterialBibliografico libro = new MaterialBibliografico("El examen", "Luis Aquino");

       
        libro.MostrarInformacion();
    }
}
