using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.CarParts;

namespace CarProject.CarParts.CarBody
{
    class Body:CarPart
    {
        private string name = "Body";
        private string type = "";
        private string color = "";

        public override string PartName { get { return this.name; } }

        public Body(string t, string c)
        {
            this.type = t;
            this.color = c;
        }

        public override float Price
        {
            get
            {
                return 3000;
            }
        }

        public override string Assembled_Item_Name
        {
            get { return this.color + ' ' + this.type + ' ' + this.name; }
        }
    }
}
