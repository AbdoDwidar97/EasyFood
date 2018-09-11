using DataModel;
using EasyFoodV1.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyFoodV1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClubResturants : ContentPage
	{
        ResturantPresenter ResPresenter = new ResturantPresenter();
        public ClubResturants() { }
        public ClubResturants (Club clb)
		{
            InitializeComponent ();
            Title = clb.ClubName;
            LblClubName.Text = clb.ClubName;
            ResLst.ItemsSource = ResPresenter.Fill_ResturantList();
            ResLst.ItemTapped += ResLst_ItemTapped;
		}

        private void ResLst_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Resturant res = (Resturant)e.Item;
            Navigation.PushAsync(new FoodMenu(res));
        }
    }
}