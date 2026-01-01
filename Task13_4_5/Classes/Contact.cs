using System;
using System.Collections.Generic;
using System.Text;

namespace Task13_4_5.Classes
{
    public class Contact // модель класса
    {
        public Contact( long phoneNumber, String email) // метод-конструктор
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public long PhoneNumber { get; }
        public String Email { get; }
    }
}
