using System;
using System.Collections.Generic;
using System.Text;

namespace TheConstProject
{
    public class Identity
    {
        public string name;
        public int id;

        public Identity(string studentName, int Id)
        {

        }
        public Identity(string name) : this(name, 1234)
        {

            this.name = name;

        }
        public Identity(int id) : this("R2D2", id)
        {
            this.id = id;
        }

        public Identity()
        {
        }
    }
}
