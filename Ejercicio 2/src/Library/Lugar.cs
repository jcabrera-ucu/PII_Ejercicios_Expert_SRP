using System;

namespace Library
{
    public class Lugar
    {
        public string Localidad { get; private set; }

        public Lugar(string localidad)
        {
            if (string.IsNullOrEmpty(localidad)) 
            {
                throw new Exception();
            }

            this.Localidad = localidad;
        }

        public override string ToString()
        {
            return $"Lugar ({Localidad})";
        }
    }
}

