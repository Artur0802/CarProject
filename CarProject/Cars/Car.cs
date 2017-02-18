using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.CarParts;
using CarProject.IAssembly;
using CarProject.CarParts.CarBody;
using CarProject.CarParts.CarWheel;
using CarProject.CarParts.CarEngine;
using CarProject.CarParts.TuningParts;

namespace CarProject.Cars
{
    class Car: IAssemblyItem
    {
        private string mark = "";
        private CarPart body = null;
        private CarPart wheel = null;
        private CarPart engine = null;
        List<string> carinfo = null;

        public CarPart CarBody { get { return this.body; } }
        public CarPart CarWheel { get { return this.wheel; } }
        public CarPart CarEngine { get { return this.engine; } }

        public Car(string mark, string bt, string bc, int wd, string wgt, string et, int ev)
        {
            this.mark = mark;
            this.body = new Body(bt, bc);
            this.wheel = new Wheel(wd, wgt);
            this.engine = new Engine(et, ev);
            this.CreateCarInfo();
        }

        public void TuningCar(CarPartWithTuning cpwt)
        {
            carinfo.Add(cpwt.PartName);
            carinfo.Add("Tuning price - " + cpwt.Price);
        }

        public void Give_Info_For_Buing()
        {
            foreach (string item in carinfo)
            {
                Console.WriteLine(item);
            }

        }

        public string Assembled_Item_Name
        {
            get
            {
                return "Your " + this.mark + " assembled. It contains:";
            }
            set
            { }
        }

        public float Price
        {
            get
            {
                return this.body.Price + 4 * this.wheel.Price + this.engine.Price;
            }
            set
            { }
        }

        private void CreateCarInfo()
        {
            this.carinfo = new List<string>();
            this.carinfo.Add(this.Assembled_Item_Name);
            this.carinfo.Add(this.body.Assembled_Item_Name);
            this.carinfo.Add(this.wheel.Assembled_Item_Name);
            this.carinfo.Add(this.engine.Assembled_Item_Name);
            this.carinfo.Add("You must pay " + this.Price + "$ to buy it");
        }

        public void PartEventHandler()
        {

        }
    }
}
