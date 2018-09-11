using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DataModel;
using EasyFoodV1.Presenter;

namespace EasyFoodV1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodMenu : ContentPage
	{
        FoodItemsPresenter FoodItmPrtr = new FoodItemsPresenter();

		public FoodMenu (Resturant res)
		{
			InitializeComponent ();
            Title = res.Res_Name;

            FoodMenuLst.ItemsSource = FoodItmPrtr.Resturant_Menu();
            FoodMenuLst.ItemTapped += FoodMenuLst_ItemTapped;
		}

        private void FoodMenuLst_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            FoodMenu_Item FmItem = (FoodMenu_Item)e.Item;
            Navigation.PushAsync(new OrderFrm(FmItem));
        }
    }
}