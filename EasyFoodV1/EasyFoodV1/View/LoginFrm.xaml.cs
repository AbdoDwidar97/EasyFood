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
	public partial class LoginFrm : ContentPage
	{
		public LoginFrm ()
		{
			InitializeComponent ();
            ImgLogin.Source = ImageSource.FromFile("personuser.png");
            BtnLogin.Clicked += BtnLogin_Clicked;
            BtnGoSignup.Clicked += BtnGoSignup_Clicked;

        }

        private void BtnGoSignup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserRegisterFrm());
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            
            var NewPg = new MainPage();
            Navigation.PushAsync(NewPg);
            NavigationPage.SetHasNavigationBar(NewPg, false);
        }
    }
}