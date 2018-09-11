using EasyFoodV1.MenuItem;
using EasyFoodV1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyFoodV1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
	{
        public List<MasterPageItem> menuList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            
            menuList = new List<MasterPageItem>();
            // Adding menu items to menuList and you can define title ,page and icon
            menuList.Add(new MasterPageItem() { Title = "Orders", TargetType = typeof(OrdersFrm) });
            menuList.Add(new MasterPageItem() { Title = "Settings", TargetType = typeof(Settingss) });
            menuList.Add(new MasterPageItem() { Title = "Account", TargetType = typeof(AccountFrm) });
            menuList.Add(new MasterPageItem() { Title = "Info", TargetType = typeof(Info) });
            menuList.Add(new MasterPageItem() { Title = "LogOut", TargetType = typeof(LogOutConfirmation) });

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Main4User)));
        }
        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            //Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            String PageTitle = item.Title;

            if (PageTitle == "Orders") Navigation.PushAsync(new OrdersFrm());
            else if (PageTitle == "Settings") Navigation.PushAsync(new Settingss());
            else if (PageTitle == "Account") Navigation.PushAsync(new AccountFrm());
            else if (PageTitle == "Info") Navigation.PushAsync(new Info());
            else Navigation.PushAsync(new LogOutConfirmation());

            IsPresented = false;
        }
    }
}