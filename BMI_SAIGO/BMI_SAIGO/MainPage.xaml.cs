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
            double dHeight = double.Parse(height.Text);
            double dWeight = double.Parse(weight.Text);

            double dBMI = dWeight / dHeight / dHeight;

            if (dHeight >= 3)
            {
                dHeight /= 100;
            }



            if (dBMI < 16.0)
            {
                DisplayAlert("BMI", "痩せすぎ", "OK");
            }
            else if (dBMI < 17.0)
            {
                DisplayAlert("BMI", "痩せ", "OK");
            }
            else if (dBMI < 19.0)
            {
                DisplayAlert("BMI", "痩せ気味", "OK");
            }
            else if (dBMI < 25.0)
            {
                DisplayAlert("BMI", "普通体重", "OK");
            }
            else if (dBMI < 30.0)
            {
                DisplayAlert("BMI", "前肥満", "OK");
            }
            else if (dBMI < 35.0)
            {
                DisplayAlert("BMI", "肥満（１度）", "OK");
            }
            else if (dBMI < 40.0)
            {
                DisplayAlert("BMI", "肥満（２度）", "OK");
            }
            else
            {
                DisplayAlert("BMI", "肥満（３度）", "OK");
            }
          
        }
    }
}
