using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LoveDemo
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            var x = new System.Random();
            int res = x.Next(0, 100);
            lab.Text = res + "%";
            if (res > 50)
            {
                img.Source = "heartRED.png";

            }
        }
    }
}
