using System;

namespace Library
{
    public class AppointmentService
    {
        public static Appointment CreateAppointment(DateTime date, Lugar appoinmentPlace, Paciente paciente, Doctor doctor)
        {
            return new Appointment(
                AppointmentIdSequence.NextId(),
                date,
                appoinmentPlace,
                paciente,
                doctor
            );
        }
    }
}
