using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Woker
    {
        public enum Position
        {
            Руководитель,
            Инженер,
            Начинающий
        }

        public class Worker : Note
        {
            public string Email { get; set; }
            public Position JobTitle { get; set; }

            public Worker(string fullName, string phoneNumber, string email, Position jobTitle)
                : base(fullName, phoneNumber)
            {
                Email = email;
                JobTitle = jobTitle;
            }

            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Электронная почта: {Email}, Должность: {JobTitle}");
            }
        }
    }
}
