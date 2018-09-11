using System;
using System.Collections.Generic;
using System.Text;
using DataModel;

namespace EasyFoodV1.Presenter
{
    class ResturantPresenter
    {
        public List<Resturant> Fill_ResturantList()
        {
            List<Resturant> Resturants_Lst = new List<Resturant>();

            Resturant OmdaRes = new Resturant();
            OmdaRes.Res_Name = "El-Omda";
            OmdaRes.Res_Img = "omda.png";
            Resturants_Lst.Add(OmdaRes);

            Resturant KfcRes = new Resturant();
            KfcRes.Res_Name = "Kentucky KFC";
            KfcRes.Res_Img = "kfc.png";
            Resturants_Lst.Add(KfcRes);

            Resturant MacRes = new Resturant();
            MacRes.Res_Name = "Macdonalds";
            MacRes.Res_Img = "mcdonaldlogo.png";
            Resturants_Lst.Add(MacRes);

            Resturant PregoRes = new Resturant(); 
            PregoRes.Res_Name = "Prego";
            PregoRes.Res_Img = "prego.png";
            Resturants_Lst.Add(PregoRes);

            Resturant PHRes = new Resturant();
            PHRes.Res_Name = "Pizza Hut";
            PHRes.Res_Img = "pizzahut.png";
            Resturants_Lst.Add(PHRes);

            return Resturants_Lst;

        }
    }
}

