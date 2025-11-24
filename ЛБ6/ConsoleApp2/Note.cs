using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Note
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Note(string fullName, string phoneNumber)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        public virtual void Display()
        {
            Console.WriteLine($"ФИО: {FullName}, Номер телефона: {PhoneNumber}");
        }
    }
}
