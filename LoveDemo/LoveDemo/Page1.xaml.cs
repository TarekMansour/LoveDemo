using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LoveDemo
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        protected async void btClick(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new Page2());
        }
    }
}
