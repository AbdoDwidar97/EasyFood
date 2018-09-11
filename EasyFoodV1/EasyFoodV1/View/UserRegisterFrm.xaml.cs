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
	public partial class UserRegisterFrm : ContentPage
	{
		public UserRegisterFrm ()
		{
			InitializeComponent ();
            ImgUserSignUp.Source = ImageSource.FromFile("personuser.png");

            BtnBackToLogin.Clicked += BtnBackToLogin_Clicked;
            BtnUserSignUp.Clicked += BtnUserSignUp_Clicked;
        }

        private void BtnUserSignUp_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnBackToLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}