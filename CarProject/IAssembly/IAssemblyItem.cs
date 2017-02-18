using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.IAssembly
{
    interface IAssemblyItem
    {
        string Assembled_Item_Name { get; set; }

        float Price { get; set; }
    }
}
