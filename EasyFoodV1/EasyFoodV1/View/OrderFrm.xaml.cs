using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DataModel;

namespace EasyFoodV1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderFrm : ContentPage
	{
        int Quantity = 0;
		public OrderFrm (FoodMenu_Item Itm)
		{
			InitializeComponent ();

            Title = Itm.Item_Name;
            Lbl_Item_Desc.Text = Itm.Item_Descryption;
            ItemSizePicker.ItemsSource = Get_FoodItemSize();
            ItemSizePicker.Title = "Select Size";
            ImgFoodItem.Source = ImageSource.FromFile(Itm.Item_Image);

            PtnIncrement.Clicked += PtnIncrement_Clicked;
            PtnDecrement.Clicked += PtnDecrement_Clicked;
        }

        private void PtnDecrement_Clicked(object sender, EventArgs e)
        {
            if (Quantity > 0) Quantity--;
            LblQuantity.Text = Quantity.ToString();
        }

        private void PtnIncrement_Clicked(object sender, EventArgs e)
        {
            if (Quantity < 20) Quantity++;
            LblQuantity.Text = Quantity.ToString();
        }

        private List<String> Get_FoodItemSize()
        {
            List<String> FISize = new List<String>();
            FISize.Add("Small");
            FISize.Add("Medium");
            FISize.Add("Large");
            FISize.Add("Family");
            return FISize;
        }
	}
}