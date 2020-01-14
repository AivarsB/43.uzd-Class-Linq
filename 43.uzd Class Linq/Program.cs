using System;
using System.Collections.Generic;
using System.Linq;

namespace _43.uzd_Class_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person()
                {
                    Name = "Anna",
                    Age = 18
                },
                new Person()
                {
                    Name = "Janis",
                    Age = 32
                },
                new Person()
                {
                    Name = "Peteris",
                    Age = 45
                },
                new Person()
                {
                    Name = "Juris",
                    Age = 21
                },
            };

            // ar IF un FOREACH izmantošanu:

            //foreach (var person in persons)
            //{
            //    if (person.Age > 30)
            //    {
            //        Console.WriteLine($"{person.Name} {person.Age}");
            //    }
            //}

            // ar LINQ izmantošanu:

            var personsOlder30 = persons.Where(a => a.Age > 30).ToList();

            foreach (var person in personsOlder30)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

        }
    }
}
// Uztaisīt Person klasi ar divam īpašībām Name un Age.
// Pamatprogrammā izveidot personu sarakstu ar 4 personām.
// Izmantojot LINQ atrast visas personas, kuras vecākas par 30 gadiem.
