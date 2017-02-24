using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.CarParts;
using CarProject.CarParts.TuningParts;
using CarProject.CarParts.TuningParts.ForEngine;

namespace CarProject.CarParts.CarEngine
{
    class Engine:CarPart
    {
        private string name = "engine";
        private string type = "";
        private int volume = 0; // в технической документации объем двигателя указывается в кубических см, поэтому int
        private List<Tuning> possibletuning = null;

        public override List<Tuning> PossibleTuning { get { return this.possibletuning; } }

        public Engine(string t, int v)
        {
            this.type = t;
            this.volume = Vol_Valid(v);
            this.possibletuning = new List<Tuning>();
            possibletuning.Add(new Turbo());
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
