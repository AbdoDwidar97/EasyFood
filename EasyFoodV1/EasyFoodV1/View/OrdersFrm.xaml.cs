﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyFoodV1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrdersFrm : ContentPage
	{
		public OrdersFrm ()
		{
			InitializeComponent ();
            Title = "Orders View";
		}
	}
}