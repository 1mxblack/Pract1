using System;
using System.Collections.Generic;
using System.Text;

namespace OldMlad
{
    class Person
    {
        public int year { get; set; }
        public string name { get; set; }

        public static bool operator <(Person c1, Person c2)
        {
            return c1.year < c2.year;
        }

        public static bool operator >(Person c1, Person c2)
        {
            return c1.year > c2.year;
        }

        public static bool operator ==(Person c1, Person c2)
        {
            return c1.year == c2.year;
        }
        public static bool operator !=(Person c1, Person c2)
        {
            return c1.year != c2.year;
        }

    }
}
