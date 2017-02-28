using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.CarParts.TuningParts.ForEngine
{
    class Turbo : Tuning
    {
        public override event TunningAdd Tuned;

        public override string Assembled_Item_Name { get { return "turbo"; } }

        public override float Price { get { return 2500; } }

        public override void SendTuningEvent()
        {
            Tuned();
        }
    }
}
