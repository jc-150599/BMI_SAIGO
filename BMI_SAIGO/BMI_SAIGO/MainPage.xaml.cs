using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI_SAIGO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BMI_Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("BMI", "太りすぎ", "OK");
        }
    }
}
