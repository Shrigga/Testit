using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblia
{
    class Person : ICloneable
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Book { get; set; }
        public string Zad { get; set; }
        public int Dolg { get; set; }
        public object Clone()
        {
            return new Person
            {
                Name = this.Name,
                Age = this.Age,
                Book = this.Book,
                Zad = this.Zad,
                Dolg = this.Dolg
            };
        }
    }
}
