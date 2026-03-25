using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTwo.Models
{
    internal class Staff(string name, string email, string id, string position, string department) : Person(name, email, id)
        {
        public string Position { set; get; } = position;
        public string Department { set; get; } = department;
    }
}
