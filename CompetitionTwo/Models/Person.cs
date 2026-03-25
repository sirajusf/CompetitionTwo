using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTwo.Models
{
    internal class Person(string name, string email, string id)
    {
        public string Name { set; get; } = name;
        public string Email { set; get; } = email;
        public string ID { set; get; } = id;

        public override string ToString()
        {
            return $"Name: {Name}, ID: {ID}";
        }
    }
}
