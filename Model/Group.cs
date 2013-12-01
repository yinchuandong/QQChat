using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Group
    {
        private int gId;
        public int GId
        {
            get { return this.gId; }
            set { this.gId = value; }
        }

        private string name;
        public string Name
        {
            get { return this.name; }
            set {this.name = value;}
        }
    }
}
