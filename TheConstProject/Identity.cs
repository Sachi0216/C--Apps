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
            this.name = studentName;
            this.id = Id;
        }
        public Identity(string studentName) : this(studentName, 1234)
        {

            this.name = studentName;

        }
        public Identity(int Id) : this("R2D2", Id)
        {
            this.id = Id;
        }

        public Identity()
        {
        }
    }
}
