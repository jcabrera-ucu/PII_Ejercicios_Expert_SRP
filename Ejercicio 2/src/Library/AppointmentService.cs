using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        //  Esta clase esta muy sobrecargada, tiene la responsabilidad de conocer al paciente, al doctor, y de generar las consultas.
        //  Como dice la letra, necesitamos agregar edad al paciente, especializacion a los doctores, e identificación a la consulta. 
        //  Si quisieramos agregar atributos al doctor o paciente deberiamos modificar la firma de la función, y por cada uno de estos atributos
        //  deberiamos cambiar los verificadores. Esto no aplica srp.
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
