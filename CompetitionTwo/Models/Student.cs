using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTwo.Models
{
    internal class Student(string name, string email,string id, string major, int graduationYear) : Person(name, email, id)
    {
        public string Major { set; get; } = major;
        public int GraduationYear { set; get; } = graduationYear;
    }
}
