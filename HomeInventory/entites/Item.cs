using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeInventory.entites
{
    public class Item
    {
        
            public int ItemID { get; set; }
            public string ItemName { get; set; }
            public string Unit { get; set; }
            public double Quantity { get; set; }
            public int UserID { get; set; }
        
    }
}
