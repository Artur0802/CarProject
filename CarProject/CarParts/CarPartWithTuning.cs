using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.IAssembly;
using CarProject.CarParts.TuningParts;

namespace CarProject.CarParts
{
    class CarPartWithTuning:CarPart
    {
        private CarPart carpart = null;
        private Tuning tuningpart = null;

        public CarPartWithTuning(CarPart carpart)
        {
            base.PartName = carpart.PartName;
            base.PossibleTuning = carpart.PossibleTuning;
        }

        public CarPartWithTuning(CarPart carpart, Tuning tuningpart)
        {
            if (carpart.PossibleTuning.Contains(tuningpart))
            {
                base.PartName = carpart.PartName + " was tuned by " + tuningpart.Assembled_Item_Name;
                base.Price = carpart.Price + tuningpart.Price;
                base.PossibleTuning = carpart.PossibleTuning;
                this.carpart = carpart;
                this.tuningpart = tuningpart;
                tuningpart.Tuned += EventHandler;
                tuningpart.SendTuningEvent();
            }
            else
            {
                base.PartName = carpart.PartName + " and cannot be tuned by " + tuningpart.Assembled_Item_Name;
                base.Price = 0;
                this.carpart = carpart;
                this.tuningpart = tuningpart;
                tuningpart.Tuned += EventHandler;
                tuningpart.SendTuningEvent();
            }
        }

        public void EventHandler()
        {
            Console.WriteLine("Try to add " + this.tuningpart.Assembled_Item_Name);
        }
    }
}
