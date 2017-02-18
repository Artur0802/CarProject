using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.CarParts;

namespace CarProject.CarParts.CarEngine
{
    class Engine:CarPart
    {
        private string name = "engine";
        private string type = "";
        private int volume = 0; // в технической документации объем двигателя указывается в кубических см, поэтому int

        public Engine() { }

        public Engine(string t, int v)
        {
            this.type = t;
            this.volume = Vol_Valid(v);
        }

        public override float Price
        {
            get
            {
                if (this.type == "gas")
                {
                    if (this.volume >= 2000)
                        return 2000;
                    else return 1500;
                }
                else
                {
                    if (this.volume >= 2000)
                        return 3000;
                    else return 2500;
                }
            }
        }

        private int Vol_Valid(int v)
        {
            if (v <= 0)
            {
                Console.WriteLine("Engine's volume can't be 0");
                return 1300;
            }
            else return v;
        }

        public override string Assembled_Item_Name
        {
            get { return this.type + ' ' + this.name + " (" + this.volume + " ccm)"; }
        }
    }
}
