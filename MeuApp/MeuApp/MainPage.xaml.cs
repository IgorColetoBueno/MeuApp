using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MeuApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MeuSlider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MeuLabel.Text = Convert.ToString("(" + MeuSlider1.Value + " , " + MeuSlider2.Value + ")");
            MeuLabel.TranslationX = MeuSlider1.Value;
            //MeuLabel.RotationY = MeuSlider1.Value;
            
        }
        private void MeuSlider2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MeuLabel.Text = Convert.ToString("(" + MeuSlider1.Value + " , " + MeuSlider2.Value + ")");
            MeuLabel.TranslationY = MeuSlider2.Value;
            //MeuLabel.RotationX = MeuSlider2.Value;            
        }
    }
}
