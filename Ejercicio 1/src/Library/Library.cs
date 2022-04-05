using System;
using System.Collections.Generic;

namespace SRP
{
    public class Library
    {
        public List<Libro> Libros { get; private set; } = new List<Libro>();

        public List<String> Sectores { get; private set; } = new List<String>();

        public List<String> Estantes { get; private set; } = new List<String>();

        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            this.Libros.Add(libro);
            this.Sectores.Add(sector);
            this.Estantes.Add(estante);
        }
    }
}
