using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.IAssembly;

namespace CarProject.CarParts.TuningParts
{
    delegate void TunningAdd();

    abstract class Tuning:IAssemblyItem
    {
        public virtual event TunningAdd Tuned;

        public virtual string Assembled_Item_Name { get; set; }

        public virtual float Price { get; set; }

        public virtual void SendTuningEvent()
        {
            Tuned();
        }

        public virtual bool Equals(Tuning other)
        { return true; }
    }
}
