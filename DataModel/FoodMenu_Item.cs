using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
    public class FoodMenu_Item
    {
        public int Item_ID { get; set; }
        public String Item_Name { get; set; }
        public String Item_Descryption { get; set; }
        public double Price { get; set; }
        public int Resturant_ID { get; set; }
        public String Item_Image { get; set; }
    }
}
