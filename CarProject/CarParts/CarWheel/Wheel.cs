using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.CarParts;

namespace CarProject.CarParts.CarWheel
{
    class Wheel:CarPart
    {
        private string name = "Wheels";
        private int diameter = 0;
        private string gum_type = "";

        public Wheel(int d, string gt)
        {
            this.diameter = Diam_Valid(d);
            this.gum_type = gt;
        }

        public override float Price
        {
            get
            {
                if (this.diameter <= 15)
                {
                    if (this.gum_type == "universal")
                        return 300;
                    else return 400;
                }
                else
                {
                    if (this.gum_type == "universal")
                        return 500;
                    else return 600;
                }
            }
        }

        private int Diam_Valid(int d)
        {
            if (d <= 10)
            {
                Console.WriteLine("Disk diameter can't be smaller than 11" + '"');
                return 11;
            }
            else return d;
        }

        public override string Assembled_Item_Name
        {
            get { return this.name + " with " + this.diameter + '"' + " disks and " + this.gum_type + " gum"; }
        }
    }
}
