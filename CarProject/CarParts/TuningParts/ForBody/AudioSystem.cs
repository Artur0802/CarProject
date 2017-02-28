using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.CarParts.TuningParts.ForBody
{
    class AudioSystem : Tuning
    {
        public override event TunningAdd Tuned;

        public override string Assembled_Item_Name { get { return "audiosystem"; } }

        public override float Price { get { return 1000; } }

        public override void SendTuningEvent()
        {
            Tuned();
        }

        public override bool Equals(Tuning other)
        {
            if (this.Assembled_Item_Name == other.Assembled_Item_Name && this.Price == other.Price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
