using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EasyFoodV1.Presenter;
using DataModel;

namespace EasyFoodV1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Main4User : ContentPage
	{
        ClubPresenter ClbPstr = new ClubPresenter();

        public Main4User ()
		{
			InitializeComponent ();
            ClubsLst.ItemsSource = ClbPstr.FillClubs();
            ClubsLst.ItemTapped += ClubsLst_ItemTapped;
        }

        private void ClubsLst_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Club SelectedClub = (Club)e.Item;
            Navigation.PushAsync(new ClubResturants(SelectedClub));
        }
    }
}