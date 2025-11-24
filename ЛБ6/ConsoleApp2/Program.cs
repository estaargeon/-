using ConsoleApp2;
using System;
using System.Collections.Generic;
using static ConsoleApp2.Woker;

class Program
{
    static void Main()
    {
        List<Note> notes = new List<Note>
        {
            new Worker("Иванов Иван", "123-4567", "ivanov@mail.com", Position.Инженер),
            new Worker("Петров Петр", "234-5678", "petrov@mail.com", Position.Руководитель),
            new Note("Сидоров Сидор", "345-6789")
        };

        Console.Write("Введите первую букву фамилии для поиска: ");
        char initial = Console.ReadKey().KeyChar;
        Console.WriteLine();

        bool found = false;
        foreach (var note in notes)
        {
            if (note.FullName.StartsWith(initial))
            {
                note.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Записи с такой фамилией не найдены.");
        }
    }
}
