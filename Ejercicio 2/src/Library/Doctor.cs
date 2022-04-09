using System;

namespace Library
{
    public class Doctor
    {
        public string Name { get; }

        public string Especialidad { get; }

        public Doctor(string name, string especialidad)
        {
            if (string.IsNullOrEmpty(name) 
                || string.IsNullOrEmpty(especialidad))
            {
                throw new Exception();
            }

            this.Name = name;
            this.Especialidad = especialidad;
        }

        public override string ToString()
        {
            return $"Doctor (Name ({Name}); Especialidad ({Especialidad}))";
        }
    }
}
