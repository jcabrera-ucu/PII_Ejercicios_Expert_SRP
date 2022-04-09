using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Appointment app1 = AppointmentService.CreateAppointment(
                DateTime.Now,
                new Lugar("Wall Street"),
                new Paciente(
                    "986782342",
                    "Steven Jhonson",
                    "5555-555-555",
                    44
                ),
                new Doctor(
                    "Armand",
                    "Proctólogo"
                )
            );

            Console.WriteLine($"{app1}");

            Appointment app2 = AppointmentService.CreateAppointment(
                DateTime.Now,
                new Lugar("Ucu"),
                new Paciente(
                    "123456789",
                    "Pepe Zapatero",
                    "1234-444-321",
                    20
                ),
                new Doctor(
                    "Roberto Carnicero",
                    "Cirujano"
                )
            );

            Console.WriteLine($"{app2}");
        }
    }
}
