using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.IAssembly;

namespace CarProject.CarParts
{
    abstract class CarPart:IAssemblyItem
    {
        private string partname = "";
        private float partprice = 0;

        public virtual string PartName
        {
            get { return this.partname; }
            set { this.partname = value; }
        }

        public virtual float Price
        {
            get { return this.partprice; }
            set { this.partprice = value; }
        }

        public virtual string Assembled_Item_Name{ get; set; }
    }
}
