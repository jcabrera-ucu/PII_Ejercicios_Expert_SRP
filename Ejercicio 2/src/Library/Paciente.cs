using System;

namespace Library
{
    public class Paciente
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public string PhoneNumber { get; private set; }

        public int Edad { get; private set; }

        public Paciente(string id, string name, string phoneNumber, int edad)
        {
            if (string.IsNullOrEmpty(id) 
                || string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(phoneNumber) 
                || edad < 0) 
            {
                throw new Exception();
            }

            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Edad = edad;
        }

        public override string ToString()
        {
            return $"Paciente (Id ({Id}); Name ({Name}); PhoneNumber ({PhoneNumber}); Edad ({Edad}))";
        }
    }
}
