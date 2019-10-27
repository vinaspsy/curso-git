using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Rooms
    {

        public string Name { get; set; }
        public string Email { get; set; }

        public Rooms(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }

    }
}
