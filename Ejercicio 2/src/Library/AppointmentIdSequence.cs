using System;

namespace Library
{
    class AppointmentIdSequence
    {
        private static int _nextId = 1;

        public static int NextId()
        {
            return _nextId++;
        }
    }
}
