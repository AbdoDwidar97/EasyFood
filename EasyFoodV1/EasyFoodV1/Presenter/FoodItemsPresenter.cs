using System;
using System.Collections.Generic;
using System.Text;
using DataModel;

namespace EasyFoodV1.Presenter
{
    class FoodItemsPresenter
    {
        public List<FoodMenu_Item> Resturant_Menu()
        {
            List<FoodMenu_Item> ResMenu = new List<FoodMenu_Item>();

            FoodMenu_Item PizzaItm = new FoodMenu_Item();
            PizzaItm.Item_Name = "Nice Pizza";
            PizzaItm.Item_Descryption = "Meat , Egg , Creama , Catshup , Olives";
            PizzaItm.Item_Image = "pizza.jpg";
            ResMenu.Add(PizzaItm);

            FoodMenu_Item ChickenItm = new FoodMenu_Item();
            ChickenItm.Item_Name = "Chicken Platter";
            ChickenItm.Item_Descryption = "Chicken , Rice , vegtables";
            ChickenItm.Item_Image = "chicken.png";
            ResMenu.Add(ChickenItm);

            FoodMenu_Item SeafoodItm = new FoodMenu_Item();
            SeafoodItm.Item_Name = "Seafood";
            SeafoodItm.Item_Descryption = "Chrimps , fish , caborya , Rice";
            SeafoodItm.Item_Image = "seafood.jpg";
            ResMenu.Add(SeafoodItm);

            FoodMenu_Item KosharyItm = new FoodMenu_Item();
            KosharyItm.Item_Name = "Koshary Masry";
            KosharyItm.Item_Descryption = "Rice , Nudels , Homos , Salsa";
            KosharyItm.Item_Image = "koshary.jpg";
            ResMenu.Add(KosharyItm);

            return ResMenu;
        }
    }
}
