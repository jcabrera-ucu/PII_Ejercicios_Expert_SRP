using System;

namespace Library
{
    public class Appointment
    {
        public int Id { get; }

        public DateTime Date { get; }

        public Paciente Paciente { get; }

        public Doctor Doctor { get; }

        public Lugar Lugar { get; }

        public Appointment(int id, DateTime date, Lugar lugar, Paciente paciente, Doctor doctor)
        {
            if (lugar == null
                || paciente == null
                || doctor == null)
            {
                throw new Exception();
            }

            this.Id = id;
            this.Date = date;
            this.Lugar = lugar;
            this.Paciente = paciente;
            this.Doctor = doctor;
        }

        public override string ToString()
        {
            return $"Appointment (Id ({Id}); Date ({Date}); {Lugar}; {Paciente}; {Doctor})";
        }
    }
}
